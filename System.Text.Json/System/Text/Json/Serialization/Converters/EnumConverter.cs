using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200013D RID: 317
	internal sealed class EnumConverter<T> : JsonPrimitiveConverter<T> where T : struct, Enum
	{
		// Token: 0x06000E46 RID: 3654 RVA: 0x00036FDC File Offset: 0x000351DC
		public EnumConverter(EnumConverterOptions converterOptions, JsonNamingPolicy namingPolicy, JsonSerializerOptions options)
		{
			this._converterOptions = converterOptions;
			this._namingPolicy = namingPolicy;
			this._enumFieldInfo = EnumConverter<T>.ResolveEnumFields(namingPolicy);
			this._enumFieldInfoIndex = new Dictionary<string, EnumConverter<T>.EnumFieldInfo>(StringComparer.OrdinalIgnoreCase);
			this._nameCacheForWriting = new ConcurrentDictionary<ulong, JsonEncodedText>();
			this._nameCacheForReading = new ConcurrentDictionary<string, ulong>(StringComparer.Ordinal);
			JavaScriptEncoder encoder = options.Encoder;
			foreach (EnumConverter<T>.EnumFieldInfo enumFieldInfo2 in this._enumFieldInfo)
			{
				this.<.ctor>g__AddToEnumFieldIndex|10_0(enumFieldInfo2);
				JsonEncodedText value = JsonEncodedText.Encode(enumFieldInfo2.JsonName, encoder);
				this._nameCacheForWriting.TryAdd(enumFieldInfo2.Key, value);
				this._nameCacheForReading.TryAdd(enumFieldInfo2.JsonName, enumFieldInfo2.Key);
			}
			if (namingPolicy != null)
			{
				foreach (EnumConverter<T>.EnumFieldInfo enumFieldInfo3 in this._enumFieldInfo)
				{
					if (enumFieldInfo3.Kind == EnumConverter<T>.EnumFieldNameKind.NamingPolicy)
					{
						this.<.ctor>g__AddToEnumFieldIndex|10_0(new EnumConverter<T>.EnumFieldInfo(enumFieldInfo3.Key, EnumConverter<T>.EnumFieldNameKind.Default, enumFieldInfo3.OriginalName, enumFieldInfo3.OriginalName));
					}
				}
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x000370E0 File Offset: 0x000352E0
		public unsafe override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			JsonTokenType tokenType = reader.TokenType;
			T result;
			if (tokenType != JsonTokenType.String)
			{
				if (tokenType == JsonTokenType.Number)
				{
					if ((this._converterOptions & EnumConverterOptions.AllowNumbers) != (EnumConverterOptions)0)
					{
						switch (EnumConverter<T>.s_enumTypeCode)
						{
						case TypeCode.SByte:
						{
							sbyte b;
							if (reader.TryGetSByte(out b))
							{
								return *Unsafe.As<sbyte, T>(ref b);
							}
							break;
						}
						case TypeCode.Byte:
						{
							byte b2;
							if (reader.TryGetByte(out b2))
							{
								return *Unsafe.As<byte, T>(ref b2);
							}
							break;
						}
						case TypeCode.Int16:
						{
							short num;
							if (reader.TryGetInt16(out num))
							{
								return *Unsafe.As<short, T>(ref num);
							}
							break;
						}
						case TypeCode.UInt16:
						{
							ushort num2;
							if (reader.TryGetUInt16(out num2))
							{
								return *Unsafe.As<ushort, T>(ref num2);
							}
							break;
						}
						case TypeCode.Int32:
						{
							int num3;
							if (reader.TryGetInt32(out num3))
							{
								return *Unsafe.As<int, T>(ref num3);
							}
							break;
						}
						case TypeCode.UInt32:
						{
							uint num4;
							if (reader.TryGetUInt32(out num4))
							{
								return *Unsafe.As<uint, T>(ref num4);
							}
							break;
						}
						case TypeCode.Int64:
						{
							long num5;
							if (reader.TryGetInt64(out num5))
							{
								return *Unsafe.As<long, T>(ref num5);
							}
							break;
						}
						case TypeCode.UInt64:
						{
							ulong num6;
							if (reader.TryGetUInt64(out num6))
							{
								return *Unsafe.As<ulong, T>(ref num6);
							}
							break;
						}
						}
					}
				}
			}
			else if ((this._converterOptions & EnumConverterOptions.AllowStrings) != (EnumConverterOptions)0 && this.TryParseEnumFromString(ref reader, out result))
			{
				return result;
			}
			ThrowHelper.ThrowJsonException(null);
			return default(T);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00037234 File Offset: 0x00035434
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			EnumConverterOptions converterOptions = this._converterOptions;
			if ((converterOptions & EnumConverterOptions.AllowStrings) != (EnumConverterOptions)0)
			{
				ulong key = EnumConverter<T>.ConvertToUInt64(value);
				JsonEncodedText value2;
				if (this._nameCacheForWriting.TryGetValue(key, out value2))
				{
					writer.WriteStringValue(value2);
					return;
				}
				if (this.IsDefinedValueOrCombinationOfValues(key))
				{
					string value3 = this.FormatEnumAsString(key, value, null);
					if (this._nameCacheForWriting.Count < 64)
					{
						value2 = JsonEncodedText.Encode(value3, options.Encoder);
						writer.WriteStringValue(value2);
						this._nameCacheForWriting.TryAdd(key, value2);
						return;
					}
					writer.WriteStringValue(value3);
					return;
				}
			}
			if ((converterOptions & EnumConverterOptions.AllowNumbers) == (EnumConverterOptions)0)
			{
				ThrowHelper.ThrowJsonException(null);
			}
			if (EnumConverter<T>.s_isSignedEnum)
			{
				writer.WriteNumberValue(EnumConverter<T>.ConvertToInt64(value));
				return;
			}
			writer.WriteNumberValue(EnumConverter<T>.ConvertToUInt64(value));
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000372E4 File Offset: 0x000354E4
		internal override T ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			T result;
			if (!this.TryParseEnumFromString(ref reader, out result))
			{
				ThrowHelper.ThrowJsonException(null);
			}
			return result;
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00037304 File Offset: 0x00035504
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, T value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			JsonNamingPolicy dictionaryKeyPolicy = options.DictionaryKeyPolicy;
			JsonNamingPolicy jsonNamingPolicy = (dictionaryKeyPolicy != null && dictionaryKeyPolicy != this._namingPolicy) ? dictionaryKeyPolicy : null;
			ulong num = EnumConverter<T>.ConvertToUInt64(value);
			JsonEncodedText jsonEncodedText;
			if (jsonNamingPolicy == null && this._nameCacheForWriting.TryGetValue(num, out jsonEncodedText))
			{
				writer.WritePropertyName(jsonEncodedText);
				return;
			}
			if (this.IsDefinedValueOrCombinationOfValues(num))
			{
				string text = this.FormatEnumAsString(num, value, jsonNamingPolicy);
				if (jsonNamingPolicy == null && this._nameCacheForWriting.Count < 64)
				{
					jsonEncodedText = JsonEncodedText.Encode(text, options.Encoder);
					writer.WritePropertyName(jsonEncodedText);
					this._nameCacheForWriting.TryAdd(num, jsonEncodedText);
					return;
				}
				writer.WritePropertyName(text);
				return;
			}
			else
			{
				if (EnumConverter<T>.s_isSignedEnum)
				{
					writer.WritePropertyName(EnumConverter<T>.ConvertToInt64(value));
					return;
				}
				writer.WritePropertyName(num);
				return;
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000373BC File Offset: 0x000355BC
		private unsafe bool TryParseEnumFromString(ref Utf8JsonReader reader, out T result)
		{
			int valueLength = reader.ValueLength;
			char[] array = null;
			Span<char> span;
			if (valueLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(valueLength));
			}
			Span<char> span2 = span;
			int length = reader.CopyString(span2);
			span2 = span2.Slice(0, length);
			ReadOnlySpan<char> readOnlySpan = span2.Trim();
			ConcurrentDictionary<string, ulong>.AlternateLookup<ReadOnlySpan<char>> alternateLookup = this._nameCacheForReading.GetAlternateLookup<ReadOnlySpan<char>>();
			ulong value;
			bool flag;
			if (alternateLookup.TryGetValue(readOnlySpan, out value))
			{
				result = EnumConverter<T>.ConvertFromUInt64(value);
				flag = true;
			}
			else
			{
				if (JsonHelpers.IntegerRegex.IsMatch(readOnlySpan))
				{
					if ((this._converterOptions & EnumConverterOptions.AllowNumbers) != (EnumConverterOptions)0)
					{
						flag = Enum.TryParse<T>(readOnlySpan, out result);
					}
					else
					{
						result = default(T);
						flag = false;
					}
				}
				else
				{
					flag = this.TryParseNamedEnum(readOnlySpan, out result);
				}
				if (flag && this._nameCacheForReading.Count < 64)
				{
					alternateLookup.TryAdd(readOnlySpan, EnumConverter<T>.ConvertToUInt64(result));
				}
			}
			if (array != null)
			{
				span2.Clear();
				ArrayPool<char>.Shared.Return(array, false);
			}
			return flag;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000374CC File Offset: 0x000356CC
		private bool TryParseNamedEnum(ReadOnlySpan<char> source, out T result)
		{
			Dictionary<string, EnumConverter<T>.EnumFieldInfo>.AlternateLookup<ReadOnlySpan<char>> alternateLookup = this._enumFieldInfoIndex.GetAlternateLookup<ReadOnlySpan<char>>();
			ReadOnlySpan<char> readOnlySpan = source;
			ulong num = 0UL;
			for (;;)
			{
				int num2 = readOnlySpan.IndexOf(',');
				ReadOnlySpan<char> readOnlySpan2;
				if (num2 == -1)
				{
					readOnlySpan2 = readOnlySpan;
					readOnlySpan = default(ReadOnlySpan<char>);
				}
				else
				{
					readOnlySpan2 = readOnlySpan.Slice(0, num2).TrimEnd();
					readOnlySpan = readOnlySpan.Slice(num2 + 1).TrimStart();
				}
				EnumConverter<T>.EnumFieldInfo enumFieldInfo;
				if (!alternateLookup.TryGetValue(readOnlySpan2, out enumFieldInfo))
				{
					break;
				}
				EnumConverter<T>.EnumFieldInfo matchingField = enumFieldInfo.GetMatchingField(readOnlySpan2);
				if (matchingField == null)
				{
					break;
				}
				num |= matchingField.Key;
				if (readOnlySpan.IsEmpty)
				{
					goto Block_4;
				}
			}
			result = default(T);
			return false;
			Block_4:
			result = EnumConverter<T>.ConvertFromUInt64(num);
			return true;
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0003756C File Offset: 0x0003576C
		private unsafe static ulong ConvertToUInt64(T value)
		{
			switch (EnumConverter<T>.s_enumTypeCode)
			{
			case TypeCode.Int16:
			case TypeCode.UInt16:
				return (ulong)(*Unsafe.As<T, ushort>(ref value));
			case TypeCode.Int32:
			case TypeCode.UInt32:
				return (ulong)(*Unsafe.As<T, uint>(ref value));
			case TypeCode.Int64:
			case TypeCode.UInt64:
				return *Unsafe.As<T, ulong>(ref value);
			default:
				return (ulong)(*Unsafe.As<T, byte>(ref value));
			}
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000375C8 File Offset: 0x000357C8
		private unsafe static long ConvertToInt64(T value)
		{
			switch (EnumConverter<T>.s_enumTypeCode)
			{
			case TypeCode.Int16:
				return (long)(*Unsafe.As<T, short>(ref value));
			case TypeCode.Int32:
				return (long)(*Unsafe.As<T, int>(ref value));
			case TypeCode.Int64:
				return *Unsafe.As<T, long>(ref value);
			}
			return (long)(*Unsafe.As<T, sbyte>(ref value));
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00037620 File Offset: 0x00035820
		private unsafe static T ConvertFromUInt64(ulong value)
		{
			switch (EnumConverter<T>.s_enumTypeCode)
			{
			case TypeCode.Int16:
			case TypeCode.UInt16:
			{
				ushort num = (ushort)value;
				return *Unsafe.As<ushort, T>(ref num);
			}
			case TypeCode.Int32:
			case TypeCode.UInt32:
			{
				uint num2 = (uint)value;
				return *Unsafe.As<uint, T>(ref num2);
			}
			case TypeCode.Int64:
			case TypeCode.UInt64:
			{
				ulong num3 = value;
				return *Unsafe.As<ulong, T>(ref num3);
			}
			default:
			{
				byte b = (byte)value;
				return *Unsafe.As<byte, T>(ref b);
			}
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00037698 File Offset: 0x00035898
		private unsafe string FormatEnumAsString(ulong key, T value, JsonNamingPolicy dictionaryKeyPolicy)
		{
			if (EnumConverter<T>.s_isFlagsEnum)
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
				using (ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer))
				{
					ulong num = key;
					foreach (EnumConverter<T>.EnumFieldInfo enumFieldInfo2 in this._enumFieldInfo)
					{
						ulong key2 = enumFieldInfo2.Key;
						if ((key2 == 0UL) ? (key == 0UL) : ((num & key2) == key2))
						{
							num &= ~key2;
							string s = (dictionaryKeyPolicy != null) ? EnumConverter<T>.ResolveAndValidateJsonName(enumFieldInfo2.OriginalName, dictionaryKeyPolicy, enumFieldInfo2.Kind) : enumFieldInfo2.JsonName;
							if (valueStringBuilder.Length > 0)
							{
								valueStringBuilder.Append(", ");
							}
							valueStringBuilder.Append(s);
							if (num == 0UL)
							{
								break;
							}
						}
					}
					return valueStringBuilder.ToString();
				}
			}
			foreach (EnumConverter<T>.EnumFieldInfo enumFieldInfo3 in this._enumFieldInfo)
			{
				if (enumFieldInfo3.Key == key)
				{
					return EnumConverter<T>.ResolveAndValidateJsonName(enumFieldInfo3.OriginalName, dictionaryKeyPolicy, enumFieldInfo3.Kind);
				}
			}
			return null;
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000377C0 File Offset: 0x000359C0
		private bool IsDefinedValueOrCombinationOfValues(ulong key)
		{
			EnumConverter<T>.EnumFieldInfo[] enumFieldInfo;
			if (EnumConverter<T>.s_isFlagsEnum)
			{
				ulong num = key;
				enumFieldInfo = this._enumFieldInfo;
				for (int i = 0; i < enumFieldInfo.Length; i++)
				{
					ulong key2 = enumFieldInfo[i].Key;
					if ((key2 == 0UL) ? (key == 0UL) : ((num & key2) == key2))
					{
						num &= ~key2;
						if (num == 0UL)
						{
							return true;
						}
					}
				}
				return false;
			}
			enumFieldInfo = this._enumFieldInfo;
			for (int i = 0; i < enumFieldInfo.Length; i++)
			{
				if (enumFieldInfo[i].Key == key)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00037838 File Offset: 0x00035A38
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			if ((this._converterOptions & EnumConverterOptions.AllowStrings) == (EnumConverterOptions)0)
			{
				return new JsonSchema
				{
					Type = JsonSchemaType.Integer
				};
			}
			if (EnumConverter<T>.s_isFlagsEnum)
			{
				return new JsonSchema
				{
					Type = JsonSchemaType.String
				};
			}
			JsonArray jsonArray = new JsonArray(null);
			foreach (EnumConverter<T>.EnumFieldInfo enumFieldInfo2 in this._enumFieldInfo)
			{
				jsonArray.Add(enumFieldInfo2.JsonName);
			}
			return new JsonSchema
			{
				Enum = jsonArray
			};
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000378B8 File Offset: 0x00035AB8
		private static EnumConverter<T>.EnumFieldInfo[] ResolveEnumFields(JsonNamingPolicy namingPolicy)
		{
			string[] names = Enum.GetNames<T>();
			T[] values = Enum.GetValues<T>();
			Dictionary<string, string> dictionary = null;
			foreach (FieldInfo fieldInfo in typeof(T).GetFields(BindingFlags.Static | BindingFlags.Public))
			{
				JsonStringEnumMemberNameAttribute customAttribute = fieldInfo.GetCustomAttribute<JsonStringEnumMemberNameAttribute>();
				if (customAttribute != null)
				{
					Dictionary<string, string> dictionary2;
					if ((dictionary2 = dictionary) == null)
					{
						dictionary2 = (dictionary = new Dictionary<string, string>(StringComparer.Ordinal));
					}
					dictionary2.Add(fieldInfo.Name, customAttribute.Name);
				}
			}
			EnumConverter<T>.EnumFieldInfo[] array = new EnumConverter<T>.EnumFieldInfo[names.Length];
			for (int j = 0; j < names.Length; j++)
			{
				string text = names[j];
				ulong key = EnumConverter<T>.ConvertToUInt64(values[j]);
				string text2;
				EnumConverter<T>.EnumFieldNameKind kind;
				if (dictionary != null && dictionary.TryGetValue(text, out text2))
				{
					text = text2;
					kind = EnumConverter<T>.EnumFieldNameKind.Attribute;
				}
				else
				{
					kind = ((namingPolicy != null) ? EnumConverter<T>.EnumFieldNameKind.NamingPolicy : EnumConverter<T>.EnumFieldNameKind.Default);
				}
				string jsonName = EnumConverter<T>.ResolveAndValidateJsonName(text, namingPolicy, kind);
				array[j] = new EnumConverter<T>.EnumFieldInfo(key, kind, text, jsonName);
			}
			return array;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000379A0 File Offset: 0x00035BA0
		private static string ResolveAndValidateJsonName(string name, JsonNamingPolicy namingPolicy, EnumConverter<T>.EnumFieldNameKind kind)
		{
			if (kind != EnumConverter<T>.EnumFieldNameKind.Attribute && namingPolicy != null)
			{
				name = namingPolicy.ConvertName(name);
			}
			if (string.IsNullOrEmpty(name) || char.IsWhiteSpace(name[0]) || char.IsWhiteSpace(name[name.Length - 1]) || (EnumConverter<T>.s_isFlagsEnum && name.AsSpan().IndexOf(',') >= 0))
			{
				ThrowHelper.ThrowInvalidOperationException_UnsupportedEnumIdentifier(typeof(T), name);
			}
			return name;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00037A5F File Offset: 0x00035C5F
		[CompilerGenerated]
		private void <.ctor>g__AddToEnumFieldIndex|10_0(EnumConverter<T>.EnumFieldInfo fieldInfo)
		{
			if (!this._enumFieldInfoIndex.TryAdd(fieldInfo.JsonName, fieldInfo))
			{
				this._enumFieldInfoIndex[fieldInfo.JsonName].AppendConflictingField(fieldInfo);
			}
		}

		// Token: 0x04000451 RID: 1105
		private static readonly TypeCode s_enumTypeCode = Type.GetTypeCode(typeof(T));

		// Token: 0x04000452 RID: 1106
		private static readonly bool s_isSignedEnum = EnumConverter<T>.s_enumTypeCode % TypeCode.DBNull == TypeCode.Object;

		// Token: 0x04000453 RID: 1107
		private static readonly bool s_isFlagsEnum = typeof(T).IsDefined(typeof(FlagsAttribute), false);

		// Token: 0x04000454 RID: 1108
		private readonly EnumConverterOptions _converterOptions;

		// Token: 0x04000455 RID: 1109
		private readonly JsonNamingPolicy _namingPolicy;

		// Token: 0x04000456 RID: 1110
		private readonly EnumConverter<T>.EnumFieldInfo[] _enumFieldInfo;

		// Token: 0x04000457 RID: 1111
		private readonly Dictionary<string, EnumConverter<T>.EnumFieldInfo> _enumFieldInfoIndex;

		// Token: 0x04000458 RID: 1112
		private readonly ConcurrentDictionary<ulong, JsonEncodedText> _nameCacheForWriting;

		// Token: 0x04000459 RID: 1113
		private readonly ConcurrentDictionary<string, ulong> _nameCacheForReading;

		// Token: 0x0200013E RID: 318
		private sealed class EnumFieldInfo
		{
			// Token: 0x06000E57 RID: 3671 RVA: 0x00037A8C File Offset: 0x00035C8C
			public EnumFieldInfo(ulong key, EnumConverter<T>.EnumFieldNameKind kind, string originalName, string jsonName)
			{
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00037AB1 File Offset: 0x00035CB1
			public EnumConverter<T>.EnumFieldNameKind Kind { get; } = kind;

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00037AB9 File Offset: 0x00035CB9
			public ulong Key { get; } = key;

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00037AC1 File Offset: 0x00035CC1
			public string OriginalName { get; } = originalName;

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x06000E5B RID: 3675 RVA: 0x00037AC9 File Offset: 0x00035CC9
			public string JsonName { get; } = jsonName;

			// Token: 0x06000E5C RID: 3676 RVA: 0x00037AD4 File Offset: 0x00035CD4
			public void AppendConflictingField(EnumConverter<T>.EnumFieldInfo other)
			{
				if (EnumConverter<T>.EnumFieldInfo.<AppendConflictingField>g__ConflictsWith|14_0(this, other))
				{
					return;
				}
				List<EnumConverter<T>.EnumFieldInfo> list;
				if ((list = this._conflictingFields) == null)
				{
					list = (this._conflictingFields = new List<EnumConverter<T>.EnumFieldInfo>());
				}
				List<EnumConverter<T>.EnumFieldInfo> list2 = list;
				using (List<EnumConverter<T>.EnumFieldInfo>.Enumerator enumerator = list2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (EnumConverter<T>.EnumFieldInfo.<AppendConflictingField>g__ConflictsWith|14_0(enumerator.Current, other))
						{
							return;
						}
					}
				}
				list2.Add(other);
			}

			// Token: 0x06000E5D RID: 3677 RVA: 0x00037B50 File Offset: 0x00035D50
			public EnumConverter<T>.EnumFieldInfo GetMatchingField(ReadOnlySpan<char> input)
			{
				if (this.Kind == EnumConverter<T>.EnumFieldNameKind.Default || input.SequenceEqual(this.JsonName.AsSpan()))
				{
					return this;
				}
				List<EnumConverter<T>.EnumFieldInfo> conflictingFields = this._conflictingFields;
				if (conflictingFields != null)
				{
					foreach (EnumConverter<T>.EnumFieldInfo enumFieldInfo in conflictingFields)
					{
						if (enumFieldInfo.Kind == EnumConverter<T>.EnumFieldNameKind.Default || input.SequenceEqual(enumFieldInfo.JsonName.AsSpan()))
						{
							return enumFieldInfo;
						}
					}
				}
				return null;
			}

			// Token: 0x06000E5E RID: 3678 RVA: 0x00037BE0 File Offset: 0x00035DE0
			[CompilerGenerated]
			internal static bool <AppendConflictingField>g__ConflictsWith|14_0(EnumConverter<T>.EnumFieldInfo current, EnumConverter<T>.EnumFieldInfo other)
			{
				return current.Kind == EnumConverter<T>.EnumFieldNameKind.Default || (other.Kind != EnumConverter<T>.EnumFieldNameKind.Default && current.JsonName.Equals(other.JsonName, StringComparison.Ordinal));
			}

			// Token: 0x0400045A RID: 1114
			private List<EnumConverter<T>.EnumFieldInfo> _conflictingFields;
		}

		// Token: 0x0200013F RID: 319
		private enum EnumFieldNameKind
		{
			// Token: 0x04000460 RID: 1120
			Default,
			// Token: 0x04000461 RID: 1121
			NamingPolicy,
			// Token: 0x04000462 RID: 1122
			Attribute
		}
	}
}
