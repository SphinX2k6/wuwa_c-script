using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200008E RID: 142
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonPropertyNameAttribute : JsonAttribute
	{
		// Token: 0x060008F4 RID: 2292 RVA: 0x00028130 File Offset: 0x00026330
		public JsonPropertyNameAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0002813F File Offset: 0x0002633F
		public string Name { get; }
	}
}
