using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000CE RID: 206
	[NullableContext(1)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class JsonParameterInfoValues
	{
		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0002DE05 File Offset: 0x0002C005
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0002DE0D File Offset: 0x0002C00D
		public string Name { get; set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0002DE16 File Offset: 0x0002C016
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0002DE1E File Offset: 0x0002C01E
		public Type ParameterType { get; set; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0002DE27 File Offset: 0x0002C027
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x0002DE2F File Offset: 0x0002C02F
		public int Position { get; set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0002DE38 File Offset: 0x0002C038
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x0002DE40 File Offset: 0x0002C040
		public bool HasDefaultValue { get; set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0002DE49 File Offset: 0x0002C049
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x0002DE51 File Offset: 0x0002C051
		[Nullable(2)]
		public object DefaultValue { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0002DE5A File Offset: 0x0002C05A
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x0002DE62 File Offset: 0x0002C062
		public bool IsNullable { get; set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0002DE6B File Offset: 0x0002C06B
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x0002DE73 File Offset: 0x0002C073
		public bool IsMemberInitializer { get; set; }
	}
}
