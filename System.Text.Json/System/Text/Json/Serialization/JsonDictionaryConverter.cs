using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A0 RID: 160
	internal abstract class JsonDictionaryConverter<TDictionary> : JsonResumableConverter<TDictionary>
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00028D64 File Offset: 0x00026F64
		private protected sealed override ConverterStrategy GetDefaultConverterStrategy()
		{
			return ConverterStrategy.Dictionary;
		}

		// Token: 0x06000942 RID: 2370
		protected internal abstract bool OnWriteResume(Utf8JsonWriter writer, TDictionary dictionary, JsonSerializerOptions options, ref WriteStack state);
	}
}
