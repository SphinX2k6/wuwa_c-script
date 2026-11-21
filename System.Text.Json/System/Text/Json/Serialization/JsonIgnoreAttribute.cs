using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200008A RID: 138
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonIgnoreAttribute : JsonAttribute
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x000280B3 File Offset: 0x000262B3
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x000280BB File Offset: 0x000262BB
		public JsonIgnoreCondition Condition { get; set; } = JsonIgnoreCondition.Always;
	}
}
