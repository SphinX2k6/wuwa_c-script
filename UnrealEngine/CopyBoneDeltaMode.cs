using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000314 RID: 788
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.CopyBoneDeltaMode")]
	public enum CopyBoneDeltaMode : byte
	{
		// Token: 0x040012D8 RID: 4824
		Accumulate,
		// Token: 0x040012D9 RID: 4825
		Copy,
		// Token: 0x040012DA RID: 4826
		CopyBoneDeltaMode_MAX
	}
}
