using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000186 RID: 390
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvTestScoreOperator")]
	public enum EEnvTestScoreOperator
	{
		// Token: 0x040006C8 RID: 1736
		AverageScore,
		// Token: 0x040006C9 RID: 1737
		MinScore,
		// Token: 0x040006CA RID: 1738
		MaxScore,
		// Token: 0x040006CB RID: 1739
		Multiply,
		// Token: 0x040006CC RID: 1740
		EEnvTestScoreOperator_MAX
	}
}
