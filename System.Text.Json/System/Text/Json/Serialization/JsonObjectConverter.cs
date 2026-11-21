using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A2 RID: 162
	internal abstract class JsonObjectConverter<T> : JsonResumableConverter<T>
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x00003363 File Offset: 0x00001563
		private protected sealed override ConverterStrategy GetDefaultConverterStrategy()
		{
			return ConverterStrategy.Object;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}
	}
}
