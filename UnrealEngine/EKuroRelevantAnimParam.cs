using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A94 RID: 2708
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroRelevantAnimParam")]
	public enum EKuroRelevantAnimParam : byte
	{
		// Token: 0x04004888 RID: 18568
		ElapsedTime,
		// Token: 0x04004889 RID: 18569
		RemainingTime,
		// Token: 0x0400488A RID: 18570
		ElapsedFraction,
		// Token: 0x0400488B RID: 18571
		RemainingFraction,
		// Token: 0x0400488C RID: 18572
		EKuroRelevantAnimParam_MAX
	}
}
