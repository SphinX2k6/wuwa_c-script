using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Text.Json.Nodes
{
	// Token: 0x0200006D RID: 109
	internal sealed class JsonValueOfElement : JsonValue<JsonElement>
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x00024CBB File Offset: 0x00022EBB
		public JsonValueOfElement(JsonElement value, JsonNodeOptions? options) : base(value, options)
		{
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00024CC5 File Offset: 0x00022EC5
		internal override JsonElement? UnderlyingElement
		{
			get
			{
				return new JsonElement?(this.Value);
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00024CD2 File Offset: 0x00022ED2
		internal override JsonNode DeepCloneCore()
		{
			return new JsonValueOfElement(this.Value.Clone(), base.Options);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00024CEA File Offset: 0x00022EEA
		private protected override JsonValueKind GetValueKindCore()
		{
			return this.Value.ValueKind;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00024CF8 File Offset: 0x00022EF8
		internal override bool DeepEqualsCore(JsonNode otherNode)
		{
			JsonElement? underlyingElement = otherNode.UnderlyingElement;
			if (underlyingElement != null)
			{
				JsonElement valueOrDefault = underlyingElement.GetValueOrDefault();
				return JsonElement.DeepEquals(this.Value, valueOrDefault);
			}
			if (otherNode is JsonValue)
			{
				return otherNode.DeepEqualsCore(this);
			}
			return base.DeepEqualsCore(otherNode);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00024D44 File Offset: 0x00022F44
		public override TypeToConvert GetValue<TypeToConvert>()
		{
			TypeToConvert result;
			if (!this.TryGetValue<TypeToConvert>(out result))
			{
				ThrowHelper.ThrowInvalidOperationException_NodeUnableToConvertElement(this.Value.ValueKind, typeof(TypeToConvert));
			}
			return result;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00024D78 File Offset: 0x00022F78
		public override bool TryGetValue<TypeToConvert>([NotNullWhen(true)] out TypeToConvert value)
		{
			JsonElement value2 = this.Value;
			if (value2 is TypeToConvert)
			{
				TypeToConvert typeToConvert = value2 as TypeToConvert;
				value = typeToConvert;
				return true;
			}
			switch (this.Value.ValueKind)
			{
			case JsonValueKind.String:
				if (typeof(TypeToConvert) == typeof(string))
				{
					string @string = this.Value.GetString();
					value = (TypeToConvert)((object)@string);
					return true;
				}
				if (typeof(TypeToConvert) == typeof(DateTime) || typeof(TypeToConvert) == typeof(DateTime?))
				{
					DateTime dateTime;
					bool result = this.Value.TryGetDateTime(out dateTime);
					value = (TypeToConvert)((object)dateTime);
					return result;
				}
				if (typeof(TypeToConvert) == typeof(DateTimeOffset) || typeof(TypeToConvert) == typeof(DateTimeOffset?))
				{
					DateTimeOffset dateTimeOffset;
					bool result2 = this.Value.TryGetDateTimeOffset(out dateTimeOffset);
					value = (TypeToConvert)((object)dateTimeOffset);
					return result2;
				}
				if (typeof(TypeToConvert) == typeof(Guid) || typeof(TypeToConvert) == typeof(Guid?))
				{
					Guid guid;
					bool result3 = this.Value.TryGetGuid(out guid);
					value = (TypeToConvert)((object)guid);
					return result3;
				}
				if (typeof(TypeToConvert) == typeof(char) || typeof(TypeToConvert) == typeof(char?))
				{
					string string2 = this.Value.GetString();
					if (string2.Length == 1)
					{
						value = (TypeToConvert)((object)string2[0]);
						return true;
					}
				}
				break;
			case JsonValueKind.Number:
				if (typeof(TypeToConvert) == typeof(int) || typeof(TypeToConvert) == typeof(int?))
				{
					int num;
					bool result4 = this.Value.TryGetInt32(out num);
					value = (TypeToConvert)((object)num);
					return result4;
				}
				if (typeof(TypeToConvert) == typeof(long) || typeof(TypeToConvert) == typeof(long?))
				{
					long num2;
					bool result5 = this.Value.TryGetInt64(out num2);
					value = (TypeToConvert)((object)num2);
					return result5;
				}
				if (typeof(TypeToConvert) == typeof(double) || typeof(TypeToConvert) == typeof(double?))
				{
					double num3;
					bool result6 = this.Value.TryGetDouble(out num3);
					value = (TypeToConvert)((object)num3);
					return result6;
				}
				if (typeof(TypeToConvert) == typeof(short) || typeof(TypeToConvert) == typeof(short?))
				{
					short num4;
					bool result7 = this.Value.TryGetInt16(out num4);
					value = (TypeToConvert)((object)num4);
					return result7;
				}
				if (typeof(TypeToConvert) == typeof(decimal) || typeof(TypeToConvert) == typeof(decimal?))
				{
					decimal num5;
					bool result8 = this.Value.TryGetDecimal(out num5);
					value = (TypeToConvert)((object)num5);
					return result8;
				}
				if (typeof(TypeToConvert) == typeof(byte) || typeof(TypeToConvert) == typeof(byte?))
				{
					byte b;
					bool result9 = this.Value.TryGetByte(out b);
					value = (TypeToConvert)((object)b);
					return result9;
				}
				if (typeof(TypeToConvert) == typeof(float) || typeof(TypeToConvert) == typeof(float?))
				{
					float num6;
					bool result10 = this.Value.TryGetSingle(out num6);
					value = (TypeToConvert)((object)num6);
					return result10;
				}
				if (typeof(TypeToConvert) == typeof(uint) || typeof(TypeToConvert) == typeof(uint?))
				{
					uint num7;
					bool result11 = this.Value.TryGetUInt32(out num7);
					value = (TypeToConvert)((object)num7);
					return result11;
				}
				if (typeof(TypeToConvert) == typeof(ushort) || typeof(TypeToConvert) == typeof(ushort?))
				{
					ushort num8;
					bool result12 = this.Value.TryGetUInt16(out num8);
					value = (TypeToConvert)((object)num8);
					return result12;
				}
				if (typeof(TypeToConvert) == typeof(ulong) || typeof(TypeToConvert) == typeof(ulong?))
				{
					ulong num9;
					bool result13 = this.Value.TryGetUInt64(out num9);
					value = (TypeToConvert)((object)num9);
					return result13;
				}
				if (typeof(TypeToConvert) == typeof(sbyte) || typeof(TypeToConvert) == typeof(sbyte?))
				{
					sbyte b2;
					bool result14 = this.Value.TryGetSByte(out b2);
					value = (TypeToConvert)((object)b2);
					return result14;
				}
				break;
			case JsonValueKind.True:
			case JsonValueKind.False:
				if (typeof(TypeToConvert) == typeof(bool) || typeof(TypeToConvert) == typeof(bool?))
				{
					value = (TypeToConvert)((object)this.Value.GetBoolean());
					return true;
				}
				break;
			}
			value = default(TypeToConvert);
			return false;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0002538E File Offset: 0x0002358E
		public override void WriteTo(Utf8JsonWriter writer, JsonSerializerOptions options = null)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			this.Value.WriteTo(writer);
		}
	}
}
