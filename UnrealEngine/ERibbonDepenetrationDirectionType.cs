using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001649 RID: 5705
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ERibbonDepenetrationDirectionType")]
	public enum ERibbonDepenetrationDirectionType : byte
	{
		// Token: 0x0400B37B RID: 45947
		FixOffset,
		// Token: 0x0400B37C RID: 45948
		RootBoneLink,
		// Token: 0x0400B37D RID: 45949
		MeshSpaceFixedPoint,
		// Token: 0x0400B37E RID: 45950
		PrevFrameBonePosition,
		// Token: 0x0400B37F RID: 45951
		PrevFrameResidualOffset,
		// Token: 0x0400B380 RID: 45952
		ERibbonDepenetrationDirectionType_MAX
	}
}
