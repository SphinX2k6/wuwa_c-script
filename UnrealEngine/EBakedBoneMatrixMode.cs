using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A0E RID: 10766
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EBakedBoneMatrixMode")]
	public enum EBakedBoneMatrixMode : byte
	{
		// Token: 0x04015D7A RID: 89466
		Float3X4,
		// Token: 0x04015D7B RID: 89467
		Float3T_QuatR,
		// Token: 0x04015D7C RID: 89468
		DualQuat,
		// Token: 0x04015D7D RID: 89469
		EBakedBoneMatrixMode_MAX
	}
}
