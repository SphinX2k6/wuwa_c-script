using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000185 RID: 389
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvTestScoreEquation")]
	public enum EEnvTestScoreEquation
	{
		// Token: 0x040006C1 RID: 1729
		Linear,
		// Token: 0x040006C2 RID: 1730
		Square,
		// Token: 0x040006C3 RID: 1731
		InverseLinear,
		// Token: 0x040006C4 RID: 1732
		SquareRoot,
		// Token: 0x040006C5 RID: 1733
		Constant,
		// Token: 0x040006C6 RID: 1734
		EEnvTestScoreEquation_MAX
	}
}
