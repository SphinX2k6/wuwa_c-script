using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200031C RID: 796
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EKuroBlendSpaceLockInputType")]
	public enum EKuroBlendSpaceLockInputType : byte
	{
		// Token: 0x0400130D RID: 4877
		NoLock,
		// Token: 0x0400130E RID: 4878
		AlwaysLock,
		// Token: 0x0400130F RID: 4879
		OnlyLockMainAnim,
		// Token: 0x04001310 RID: 4880
		OnlyLockNotMainAnim,
		// Token: 0x04001311 RID: 4881
		EKuroBlendSpaceLockInputType_MAX
	}
}
