using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200008C RID: 140
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonNumberHandlingAttribute : JsonAttribute
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000280D3 File Offset: 0x000262D3
		public JsonNumberHandling Handling { get; }

		// Token: 0x060008EC RID: 2284 RVA: 0x000280DB File Offset: 0x000262DB
		public JsonNumberHandlingAttribute(JsonNumberHandling handling)
		{
			if (!JsonSerializer.IsValidNumberHandlingValue(handling))
			{
				throw new ArgumentOutOfRangeException("handling");
			}
			this.Handling = handling;
		}
	}
}
