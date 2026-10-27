using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000317 RID: 791
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EConstraintOffsetOption")]
	public enum EConstraintOffsetOption : byte
	{
		// Token: 0x040012E5 RID: 4837
		None,
		// Token: 0x040012E6 RID: 4838
		Offset_RefPose,
		// Token: 0x040012E7 RID: 4839
		EConstraintOffsetOption_MAX
	}
}
