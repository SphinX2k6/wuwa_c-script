using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000085 RID: 133
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonObjectCreationHandlingAttribute : JsonAttribute
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0002801F File Offset: 0x0002621F
		public JsonObjectCreationHandling Handling { get; }

		// Token: 0x060008DB RID: 2267 RVA: 0x00028027 File Offset: 0x00026227
		public JsonObjectCreationHandlingAttribute(JsonObjectCreationHandling handling)
		{
			if (!JsonSerializer.IsValidCreationHandlingValue(handling))
			{
				throw new ArgumentOutOfRangeException("handling");
			}
			this.Handling = handling;
		}
	}
}
