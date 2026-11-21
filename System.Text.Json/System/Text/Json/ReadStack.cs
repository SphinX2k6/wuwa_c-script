using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json
{
	// Token: 0x0200004D RID: 77
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	[StructLayout(LayoutKind.Auto)]
	internal struct ReadStack
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0001624E File Offset: 0x0001444E
		public readonly ref ReadStackFrame Parent
		{
			get
			{
				return ref this._stack[this._count - 2];
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00016263 File Offset: 0x00014463
		public readonly JsonPropertyInfo ParentProperty
		{
			get
			{
				if (!this.Current.HasParentObject)
				{
					return null;
				}
				return this.Parent.JsonPropertyInfo;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001627F File Offset: 0x0001447F
		public readonly bool IsContinuation
		{
			get
			{
				return this._continuationCount != 0;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001628A File Offset: 0x0001448A
		private void EnsurePushCapacity()
		{
			if (this._stack == null)
			{
				this._stack = new ReadStackFrame[4];
				return;
			}
			if (this._count - 1 == this._stack.Length)
			{
				Array.Resize<ReadStackFrame>(ref this._stack, 2 * this._stack.Length);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000162C8 File Offset: 0x000144C8
		internal void Initialize(JsonTypeInfo jsonTypeInfo, bool supportContinuation = false)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			if (options.ReferenceHandlingStrategy == ReferenceHandlingStrategy.Preserve)
			{
				this.ReferenceResolver = options.ReferenceHandler.CreateResolver(false);
				this.PreserveReferences = true;
			}
			this.Current.JsonTypeInfo = jsonTypeInfo;
			this.Current.JsonPropertyInfo = jsonTypeInfo.PropertyInfoForTypeInfo;
			this.Current.NumberHandling = this.Current.JsonPropertyInfo.EffectiveNumberHandling;
			bool canContainMetadata;
			if (!this.PreserveReferences)
			{
				PolymorphicTypeResolver polymorphicTypeResolver = jsonTypeInfo.PolymorphicTypeResolver;
				canContainMetadata = (polymorphicTypeResolver != null && polymorphicTypeResolver.UsesTypeDiscriminators);
			}
			else
			{
				canContainMetadata = true;
			}
			this.Current.CanContainMetadata = canContainMetadata;
			this.SupportContinuation = supportContinuation;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00016368 File Offset: 0x00014568
		public void Push()
		{
			if (this._continuationCount == 0)
			{
				if (this._count == 0)
				{
					this._count = 1;
				}
				else
				{
					JsonPropertyInfo jsonPropertyInfo = this.Current.JsonPropertyInfo;
					JsonTypeInfo jsonTypeInfo = ((jsonPropertyInfo != null) ? jsonPropertyInfo.JsonTypeInfo : null) ?? this.Current.CtorArgumentState.JsonParameterInfo.JsonTypeInfo;
					JsonNumberHandling? numberHandling = this.Current.NumberHandling;
					this.EnsurePushCapacity();
					this._stack[this._count - 1] = this.Current;
					this.Current = default(ReadStackFrame);
					this._count++;
					this.Current.JsonTypeInfo = jsonTypeInfo;
					this.Current.JsonPropertyInfo = jsonTypeInfo.PropertyInfoForTypeInfo;
					JsonNumberHandling? jsonNumberHandling = numberHandling;
					this.Current.NumberHandling = ((jsonNumberHandling != null) ? jsonNumberHandling : this.Current.JsonPropertyInfo.EffectiveNumberHandling);
					bool canContainMetadata;
					if (!this.PreserveReferences)
					{
						PolymorphicTypeResolver polymorphicTypeResolver = jsonTypeInfo.PolymorphicTypeResolver;
						canContainMetadata = (polymorphicTypeResolver != null && polymorphicTypeResolver.UsesTypeDiscriminators);
					}
					else
					{
						canContainMetadata = true;
					}
					this.Current.CanContainMetadata = canContainMetadata;
				}
			}
			else
			{
				int count = this._count;
				this._count = count + 1;
				if (count > 0)
				{
					this._stack[this._count - 2] = this.Current;
					this.Current = this._stack[this._count - 1];
				}
				if (this._continuationCount == this._count)
				{
					this._continuationCount = 0;
				}
			}
			this.SetConstructorArgumentState();
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000164DC File Offset: 0x000146DC
		public void Pop(bool success)
		{
			int num;
			if (!success)
			{
				if (this._continuationCount == 0)
				{
					if (this._count == 1)
					{
						this._continuationCount = 1;
						this._count = 0;
						return;
					}
					this.EnsurePushCapacity();
					num = this._count;
					this._count = num - 1;
					this._continuationCount = num;
				}
				else
				{
					num = this._count - 1;
					this._count = num;
					if (num == 0)
					{
						return;
					}
				}
				this._stack[this._count] = this.Current;
				this.Current = this._stack[this._count - 1];
				return;
			}
			num = this._count - 1;
			this._count = num;
			if (num > 0)
			{
				this.Current = this._stack[this._count - 1];
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000165A0 File Offset: 0x000147A0
		public JsonConverter InitializePolymorphicReEntry(JsonTypeInfo derivedJsonTypeInfo)
		{
			this.Current.PolymorphicJsonTypeInfo = this.Current.JsonTypeInfo;
			this.Current.JsonTypeInfo = derivedJsonTypeInfo;
			this.Current.JsonPropertyInfo = derivedJsonTypeInfo.PropertyInfoForTypeInfo;
			ref JsonNumberHandling? ptr = ref this.Current.NumberHandling;
			JsonNumberHandling? jsonNumberHandling = ptr;
			if (jsonNumberHandling == null)
			{
				ptr = this.Current.JsonPropertyInfo.NumberHandling;
			}
			this.Current.PolymorphicSerializationState = PolymorphicSerializationState.PolymorphicReEntryStarted;
			this.SetConstructorArgumentState();
			return derivedJsonTypeInfo.Converter;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001662C File Offset: 0x0001482C
		public JsonConverter ResumePolymorphicReEntry()
		{
			ref JsonTypeInfo ptr = ref this.Current.JsonTypeInfo;
			JsonTypeInfo polymorphicJsonTypeInfo = this.Current.PolymorphicJsonTypeInfo;
			JsonTypeInfo jsonTypeInfo = this.Current.JsonTypeInfo;
			ptr = polymorphicJsonTypeInfo;
			this.Current.PolymorphicJsonTypeInfo = jsonTypeInfo;
			this.Current.PolymorphicSerializationState = PolymorphicSerializationState.PolymorphicReEntryStarted;
			return this.Current.JsonTypeInfo.Converter;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0001668C File Offset: 0x0001488C
		public void ExitPolymorphicConverter(bool success)
		{
			ref JsonTypeInfo ptr = ref this.Current.JsonTypeInfo;
			JsonTypeInfo polymorphicJsonTypeInfo = this.Current.PolymorphicJsonTypeInfo;
			JsonTypeInfo jsonTypeInfo = this.Current.JsonTypeInfo;
			ptr = polymorphicJsonTypeInfo;
			this.Current.PolymorphicJsonTypeInfo = jsonTypeInfo;
			this.Current.PolymorphicSerializationState = (success ? PolymorphicSerializationState.None : PolymorphicSerializationState.PolymorphicReEntrySuspended);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000166E0 File Offset: 0x000148E0
		public string JsonPath()
		{
			StringBuilder stringBuilder = new StringBuilder("$");
			int continuationCount = this._continuationCount;
			ValueTuple<int, bool> valueTuple;
			if (continuationCount != 0)
			{
				if (continuationCount != 1)
				{
					valueTuple = new ValueTuple<int, bool>(continuationCount, false);
				}
				else
				{
					valueTuple = new ValueTuple<int, bool>(0, true);
				}
			}
			else
			{
				valueTuple = new ValueTuple<int, bool>(this._count - 1, true);
			}
			ValueTuple<int, bool> valueTuple2 = valueTuple;
			int item = valueTuple2.Item1;
			bool item2 = valueTuple2.Item2;
			for (int i = 0; i < item; i++)
			{
				ReadStack.<JsonPath>g__AppendStackFrame|22_0(stringBuilder, ref this._stack[i]);
			}
			if (item2)
			{
				ReadStack.<JsonPath>g__AppendStackFrame|22_0(stringBuilder, ref this.Current);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00016778 File Offset: 0x00014978
		public JsonTypeInfo GetTopJsonTypeInfoWithParameterizedConstructor()
		{
			for (int i = 0; i < this._count - 1; i++)
			{
				if (this._stack[i].JsonTypeInfo.UsesParameterizedConstructor)
				{
					return this._stack[i].JsonTypeInfo;
				}
			}
			return this.Current.JsonTypeInfo;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000167D0 File Offset: 0x000149D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetConstructorArgumentState()
		{
			if (this.Current.JsonTypeInfo.UsesParameterizedConstructor)
			{
				ref ArgumentState ptr = ref this.Current.CtorArgumentState;
				if (ptr == null)
				{
					ptr = new ArgumentState();
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00016808 File Offset: 0x00014A08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Path = ");
				defaultInterpolatedStringHandler.AppendFormatted(this.JsonPath());
				defaultInterpolatedStringHandler.AppendLiteral(", Current = ConverterStrategy.");
				JsonTypeInfo jsonTypeInfo = this.Current.JsonTypeInfo;
				defaultInterpolatedStringHandler.AppendFormatted<ConverterStrategy?>((jsonTypeInfo != null) ? new ConverterStrategy?(jsonTypeInfo.Converter.ConverterStrategy) : null);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				JsonTypeInfo jsonTypeInfo2 = this.Current.JsonTypeInfo;
				defaultInterpolatedStringHandler.AppendFormatted((jsonTypeInfo2 != null) ? jsonTypeInfo2.Type.Name : null);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000168AC File Offset: 0x00014AAC
		[CompilerGenerated]
		internal static void <JsonPath>g__AppendStackFrame|22_0(StringBuilder sb, ref ReadStackFrame frame)
		{
			string propertyName = ReadStack.<JsonPath>g__GetPropertyName|22_3(ref frame);
			ReadStack.<JsonPath>g__AppendPropertyName|22_2(sb, propertyName);
			if (frame.JsonTypeInfo != null && frame.IsProcessingEnumerable())
			{
				IEnumerable enumerable = frame.ReturnValue as IEnumerable;
				if (enumerable == null)
				{
					return;
				}
				if (frame.ObjectState == StackFrameObjectState.None || frame.ObjectState == StackFrameObjectState.CreatedObject || frame.ObjectState == StackFrameObjectState.ReadElements)
				{
					sb.Append('[');
					sb.Append(ReadStack.<JsonPath>g__GetCount|22_1(enumerable));
					sb.Append(']');
				}
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00016920 File Offset: 0x00014B20
		[CompilerGenerated]
		internal static int <JsonPath>g__GetCount|22_1(IEnumerable enumerable)
		{
			ICollection collection = enumerable as ICollection;
			if (collection != null)
			{
				return collection.Count;
			}
			int num = 0;
			IEnumerator enumerator = enumerable.GetEnumerator();
			while (enumerator.MoveNext())
			{
				num++;
			}
			return num;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00016958 File Offset: 0x00014B58
		[CompilerGenerated]
		internal static void <JsonPath>g__AppendPropertyName|22_2(StringBuilder sb, string propertyName)
		{
			if (propertyName != null)
			{
				if (propertyName.AsSpan().ContainsSpecialCharacters())
				{
					sb.Append("['");
					sb.Append(propertyName);
					sb.Append("']");
					return;
				}
				sb.Append('.');
				sb.Append(propertyName);
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000169A8 File Offset: 0x00014BA8
		[CompilerGenerated]
		internal static string <JsonPath>g__GetPropertyName|22_3(ref ReadStackFrame frame)
		{
			string result = null;
			byte[] array = frame.JsonPropertyName;
			if (array == null)
			{
				if (frame.JsonPropertyNameAsString != null)
				{
					result = frame.JsonPropertyNameAsString;
				}
				else
				{
					JsonPropertyInfo jsonPropertyInfo = frame.JsonPropertyInfo;
					byte[] array2;
					if ((array2 = ((jsonPropertyInfo != null) ? jsonPropertyInfo.NameAsUtf8Bytes : null)) == null)
					{
						ArgumentState ctorArgumentState = frame.CtorArgumentState;
						if (ctorArgumentState == null)
						{
							array2 = null;
						}
						else
						{
							JsonParameterInfo jsonParameterInfo = ctorArgumentState.JsonParameterInfo;
							array2 = ((jsonParameterInfo != null) ? jsonParameterInfo.JsonNameAsUtf8Bytes : null);
						}
					}
					array = array2;
				}
			}
			if (array != null)
			{
				result = JsonHelpers.Utf8GetString(array);
			}
			return result;
		}

		// Token: 0x04000136 RID: 310
		public ReadStackFrame Current;

		// Token: 0x04000137 RID: 311
		private ReadStackFrame[] _stack;

		// Token: 0x04000138 RID: 312
		private int _count;

		// Token: 0x04000139 RID: 313
		private int _continuationCount;

		// Token: 0x0400013A RID: 314
		public ReferenceResolver ReferenceResolver;

		// Token: 0x0400013B RID: 315
		public bool SupportContinuation;

		// Token: 0x0400013C RID: 316
		public string ReferenceId;

		// Token: 0x0400013D RID: 317
		public object PolymorphicTypeDiscriminator;

		// Token: 0x0400013E RID: 318
		public bool PreserveReferences;
	}
}
