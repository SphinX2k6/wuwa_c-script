using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D5 RID: 8917
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintingToolset.EMeshPaintDataColorViewMode")]
	public enum EMeshPaintDataColorViewMode : byte
	{
		// Token: 0x040120C8 RID: 73928
		Normal,
		// Token: 0x040120C9 RID: 73929
		RGB,
		// Token: 0x040120CA RID: 73930
		Alpha,
		// Token: 0x040120CB RID: 73931
		Red,
		// Token: 0x040120CC RID: 73932
		Green,
		// Token: 0x040120CD RID: 73933
		Blue,
		// Token: 0x040120CE RID: 73934
		Arrow,
		// Token: 0x040120CF RID: 73935
		Flow,
		// Token: 0x040120D0 RID: 73936
		EMeshPaintDataColorViewMode_MAX
	}
}
