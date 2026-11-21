using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json
{
	// Token: 0x0200004E RID: 78
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	[StructLayout(LayoutKind.Auto)]
	internal struct ReadStackFrame
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00016A17 File Offset: 0x00014C17
		public JsonTypeInfo BaseJsonTypeInfo
		{
			get
			{
				if (this.PolymorphicSerializationState != PolymorphicSerializationState.PolymorphicReEntryStarted)
				{
					return this.JsonTypeInfo;
				}
				return this.PolymorphicJsonTypeInfo;
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00016A2F File Offset: 0x00014C2F
		public void EndConstructorParameter()
		{
			this.CtorArgumentState.JsonParameterInfo = null;
			this.JsonPropertyName = null;
			this.PropertyState = StackFramePropertyState.None;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00016A4B File Offset: 0x00014C4B
		public void EndProperty()
		{
			this.JsonPropertyInfo = null;
			this.JsonPropertyName = null;
			this.JsonPropertyNameAsString = null;
			this.PropertyState = StackFramePropertyState.None;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00016A69 File Offset: 0x00014C69
		public void EndElement()
		{
			this.JsonPropertyNameAsString = null;
			this.PropertyState = StackFramePropertyState.None;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00016A79 File Offset: 0x00014C79
		public bool IsProcessingDictionary()
		{
			return this.JsonTypeInfo.Kind == JsonTypeInfoKind.Dictionary;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00016A89 File Offset: 0x00014C89
		public bool IsProcessingEnumerable()
		{
			return this.JsonTypeInfo.Kind == JsonTypeInfoKind.Enumerable;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00016A99 File Offset: 0x00014C99
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void MarkRequiredPropertyAsRead(JsonPropertyInfo propertyInfo)
		{
			if (propertyInfo.IsRequired)
			{
				this.RequiredPropertiesSet[propertyInfo.RequiredPropertyIndex] = true;
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00016AB5 File Offset: 0x00014CB5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void InitializeRequiredPropertiesValidationState(JsonTypeInfo typeInfo)
		{
			if (typeInfo.NumberOfRequiredProperties > 0)
			{
				this.RequiredPropertiesSet = new BitArray(typeInfo.NumberOfRequiredProperties);
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00016AD1 File Offset: 0x00014CD1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ValidateAllRequiredPropertiesAreRead(JsonTypeInfo typeInfo)
		{
			if (typeInfo.NumberOfRequiredProperties > 0 && !this.RequiredPropertiesSet.HasAllSet())
			{
				ThrowHelper.ThrowJsonException_JsonRequiredPropertyMissing(typeInfo, this.RequiredPropertiesSet);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00016AF8 File Offset: 0x00014CF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("ConverterStrategy.");
				JsonTypeInfo jsonTypeInfo = this.JsonTypeInfo;
				defaultInterpolatedStringHandler.AppendFormatted<ConverterStrategy?>((jsonTypeInfo != null) ? new ConverterStrategy?(jsonTypeInfo.Converter.ConverterStrategy) : null);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				JsonTypeInfo jsonTypeInfo2 = this.JsonTypeInfo;
				defaultInterpolatedStringHandler.AppendFormatted((jsonTypeInfo2 != null) ? jsonTypeInfo2.Type.Name : null);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x0400013F RID: 319
		public JsonPropertyInfo JsonPropertyInfo;

		// Token: 0x04000140 RID: 320
		public StackFramePropertyState PropertyState;

		// Token: 0x04000141 RID: 321
		public bool UseExtensionProperty;

		// Token: 0x04000142 RID: 322
		public byte[] JsonPropertyName;

		// Token: 0x04000143 RID: 323
		public string JsonPropertyNameAsString;

		// Token: 0x04000144 RID: 324
		public object DictionaryKey;

		// Token: 0x04000145 RID: 325
		public int OriginalDepth;

		// Token: 0x04000146 RID: 326
		public object ReturnValue;

		// Token: 0x04000147 RID: 327
		public JsonTypeInfo JsonTypeInfo;

		// Token: 0x04000148 RID: 328
		public StackFrameObjectState ObjectState;

		// Token: 0x04000149 RID: 329
		public bool CanContainMetadata;

		// Token: 0x0400014A RID: 330
		public MetadataPropertyName LatestMetadataPropertyName;

		// Token: 0x0400014B RID: 331
		public MetadataPropertyName MetadataPropertyNames;

		// Token: 0x0400014C RID: 332
		public PolymorphicSerializationState PolymorphicSerializationState;

		// Token: 0x0400014D RID: 333
		public JsonTypeInfo PolymorphicJsonTypeInfo;

		// Token: 0x0400014E RID: 334
		public int PropertyIndex;

		// Token: 0x0400014F RID: 335
		public PropertyRefCacheBuilder PropertyRefCacheBuilder;

		// Token: 0x04000150 RID: 336
		public ArgumentState CtorArgumentState;

		// Token: 0x04000151 RID: 337
		public JsonNumberHandling? NumberHandling;

		// Token: 0x04000152 RID: 338
		public BitArray RequiredPropertiesSet;

		// Token: 0x04000153 RID: 339
		public bool HasParentObject;

		// Token: 0x04000154 RID: 340
		public bool IsPopulating;
	}
}
