using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000327 RID: 807
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ERefPoseType")]
	public enum ERefPoseType
	{
		// Token: 0x04001348 RID: 4936
		EIT_LocalSpace,
		// Token: 0x04001349 RID: 4937
		EIT_Additive,
		// Token: 0x0400134A RID: 4938
		EIT_MAX
	}
}
