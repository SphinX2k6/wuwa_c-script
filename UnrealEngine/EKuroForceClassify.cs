using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A8D RID: 2701
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroForceClassify")]
	public enum EKuroForceClassify : byte
	{
		// Token: 0x0400485E RID: 18526
		Auto,
		// Token: 0x0400485F RID: 18527
		ForceDiff,
		// Token: 0x04004860 RID: 18528
		ForceNoDiff,
		// Token: 0x04004861 RID: 18529
		EKuroForceClassify_MAX
	}
}
