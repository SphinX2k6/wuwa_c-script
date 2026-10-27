using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000316 RID: 790
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EBoneModificationMode")]
	public enum EBoneModificationMode
	{
		// Token: 0x040012E0 RID: 4832
		BMM_Ignore,
		// Token: 0x040012E1 RID: 4833
		BMM_Replace,
		// Token: 0x040012E2 RID: 4834
		BMM_Additive,
		// Token: 0x040012E3 RID: 4835
		BMM_MAX
	}
}
