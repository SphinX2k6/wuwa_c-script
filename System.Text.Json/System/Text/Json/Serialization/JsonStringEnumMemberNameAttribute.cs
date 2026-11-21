using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000AA RID: 170
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class JsonStringEnumMemberNameAttribute : Attribute
	{
		// Token: 0x060009D0 RID: 2512 RVA: 0x0002A46F File Offset: 0x0002866F
		public JsonStringEnumMemberNameAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0002A47E File Offset: 0x0002867E
		public string Name { get; }
	}
}
