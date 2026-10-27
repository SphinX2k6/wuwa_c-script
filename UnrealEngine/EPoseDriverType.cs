using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000321 RID: 801
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EPoseDriverType")]
	public enum EPoseDriverType : byte
	{
		// Token: 0x04001326 RID: 4902
		SwingAndTwist,
		// Token: 0x04001327 RID: 4903
		SwingOnly,
		// Token: 0x04001328 RID: 4904
		Translation,
		// Token: 0x04001329 RID: 4905
		EPoseDriverType_MAX
	}
}
