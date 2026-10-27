using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200286F RID: 10351
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ETransitionPredictionType")]
	public enum ETransitionPredictionType
	{
		// Token: 0x0401507E RID: 86142
		Prediction_Server,
		// Token: 0x0401507F RID: 86143
		Prediction_Autonomous,
		// Token: 0x04015080 RID: 86144
		Prediction_Simulated,
		// Token: 0x04015081 RID: 86145
		Prediction_MAX
	}
}
