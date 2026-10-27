using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200031F RID: 799
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EPoseDriverOutput")]
	public enum EPoseDriverOutput : byte
	{
		// Token: 0x0400131E RID: 4894
		DrivePoses,
		// Token: 0x0400131F RID: 4895
		DriveCurves,
		// Token: 0x04001320 RID: 4896
		EPoseDriverOutput_MAX
	}
}
