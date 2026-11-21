using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000827 RID: 2087
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ETransitionPredictionType")]
	public enum ETransitionPredictionType
	{
		// Token: 0x04005254 RID: 21076
		Prediction_Server,
		// Token: 0x04005255 RID: 21077
		Prediction_Autonomous,
		// Token: 0x04005256 RID: 21078
		Prediction_Simulated,
		// Token: 0x04005257 RID: 21079
		Prediction_MAX
	}
}
