using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000090 RID: 144
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonPropertyOrderAttribute : JsonAttribute
	{
		// Token: 0x060008F7 RID: 2295 RVA: 0x00028147 File Offset: 0x00026347
		public JsonPropertyOrderAttribute(int order)
		{
			this.Order = order;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00028156 File Offset: 0x00026356
		public int Order { get; }
	}
}
