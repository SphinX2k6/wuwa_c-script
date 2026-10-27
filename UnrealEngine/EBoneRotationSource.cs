using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A1A RID: 2586
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBoneRotationSource")]
	public enum EBoneRotationSource
	{
		// Token: 0x04004538 RID: 17720
		BRS_KeepComponentSpaceRotation,
		// Token: 0x04004539 RID: 17721
		BRS_KeepLocalSpaceRotation,
		// Token: 0x0400453A RID: 17722
		BRS_CopyFromTarget,
		// Token: 0x0400453B RID: 17723
		BRS_MAX
	}
}
