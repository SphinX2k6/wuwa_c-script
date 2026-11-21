using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json
{
	// Token: 0x02000055 RID: 85
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	[StructLayout(LayoutKind.Auto)]
	internal struct WriteStackFrame
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x00017702 File Offset: 0x00015902
		public void EndCollectionElement()
		{
			this.PolymorphicSerializationState = PolymorphicSerializationState.None;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001770B File Offset: 0x0001590B
		public void EndDictionaryEntry()
		{
			this.PropertyState = StackFramePropertyState.None;
			this.PolymorphicSerializationState = PolymorphicSerializationState.None;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001771B File Offset: 0x0001591B
		public void EndProperty()
		{
			this.JsonPropertyInfo = null;
			this.JsonPropertyNameAsString = null;
			this.PropertyState = StackFramePropertyState.None;
			this.PolymorphicSerializationState = PolymorphicSerializationState.None;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00017739 File Offset: 0x00015939
		public readonly JsonTypeInfo GetNestedJsonTypeInfo()
		{
			if (this.PolymorphicSerializationState != PolymorphicSerializationState.PolymorphicReEntryStarted)
			{
				return this.JsonPropertyInfo.JsonTypeInfo;
			}
			return this.PolymorphicTypeInfo;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00017758 File Offset: 0x00015958
		public JsonTypeInfo InitializePolymorphicReEntry(Type runtimeType, JsonSerializerOptions options)
		{
			JsonTypeInfo polymorphicTypeInfo = this.PolymorphicTypeInfo;
			if (((polymorphicTypeInfo != null) ? polymorphicTypeInfo.Type : null) != runtimeType)
			{
				JsonTypeInfo typeInfoInternal = options.GetTypeInfoInternal(runtimeType, true, new bool?(true), false, true);
				this.PolymorphicTypeInfo = (typeInfoInternal.AncestorPolymorphicType ?? typeInfoInternal);
			}
			this.PolymorphicSerializationState = PolymorphicSerializationState.PolymorphicReEntryStarted;
			return this.PolymorphicTypeInfo;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000177AE File Offset: 0x000159AE
		public JsonConverter InitializePolymorphicReEntry(JsonTypeInfo derivedJsonTypeInfo)
		{
			this.PolymorphicTypeInfo = derivedJsonTypeInfo;
			this.PolymorphicSerializationState = PolymorphicSerializationState.PolymorphicReEntryStarted;
			return derivedJsonTypeInfo.Converter;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000177C4 File Offset: 0x000159C4
		public JsonConverter ResumePolymorphicReEntry()
		{
			this.PolymorphicSerializationState = PolymorphicSerializationState.PolymorphicReEntryStarted;
			return this.PolymorphicTypeInfo.Converter;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000177D8 File Offset: 0x000159D8
		public void ExitPolymorphicConverter(bool success)
		{
			this.PolymorphicSerializationState = (success ? PolymorphicSerializationState.None : PolymorphicSerializationState.PolymorphicReEntrySuspended);
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x000177E8 File Offset: 0x000159E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string DebuggerDisplay
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

		// Token: 0x04000188 RID: 392
		public IEnumerator CollectionEnumerator;

		// Token: 0x04000189 RID: 393
		public IAsyncDisposable AsyncDisposable;

		// Token: 0x0400018A RID: 394
		public bool AsyncEnumeratorIsPendingCompletion;

		// Token: 0x0400018B RID: 395
		public JsonPropertyInfo JsonPropertyInfo;

		// Token: 0x0400018C RID: 396
		public bool IsWritingExtensionDataProperty;

		// Token: 0x0400018D RID: 397
		public JsonTypeInfo JsonTypeInfo;

		// Token: 0x0400018E RID: 398
		public int OriginalDepth;

		// Token: 0x0400018F RID: 399
		public bool ProcessedStartToken;

		// Token: 0x04000190 RID: 400
		public bool ProcessedEndToken;

		// Token: 0x04000191 RID: 401
		public StackFramePropertyState PropertyState;

		// Token: 0x04000192 RID: 402
		public int EnumeratorIndex;

		// Token: 0x04000193 RID: 403
		public string JsonPropertyNameAsString;

		// Token: 0x04000194 RID: 404
		public MetadataPropertyName MetadataPropertyName;

		// Token: 0x04000195 RID: 405
		public PolymorphicSerializationState PolymorphicSerializationState;

		// Token: 0x04000196 RID: 406
		public JsonTypeInfo PolymorphicTypeInfo;

		// Token: 0x04000197 RID: 407
		public JsonNumberHandling? NumberHandling;

		// Token: 0x04000198 RID: 408
		public bool IsPushedReferenceForCycleDetection;
	}
}
