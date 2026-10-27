using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200133E RID: 4926
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayEffectMagnitudeCalculation")]
	public enum EGameplayEffectMagnitudeCalculation : byte
	{
		// Token: 0x04009AD7 RID: 39639
		ScalableFloat,
		// Token: 0x04009AD8 RID: 39640
		AttributeBased,
		// Token: 0x04009AD9 RID: 39641
		CustomCalculationClass,
		// Token: 0x04009ADA RID: 39642
		SetByCaller,
		// Token: 0x04009ADB RID: 39643
		EGameplayEffectMagnitudeCalculation_MAX
	}
}
