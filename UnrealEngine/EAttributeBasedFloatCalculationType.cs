using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001330 RID: 4912
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EAttributeBasedFloatCalculationType")]
	public enum EAttributeBasedFloatCalculationType : byte
	{
		// Token: 0x04009A88 RID: 39560
		AttributeMagnitude,
		// Token: 0x04009A89 RID: 39561
		AttributeBaseValue,
		// Token: 0x04009A8A RID: 39562
		AttributeBonusMagnitude,
		// Token: 0x04009A8B RID: 39563
		AttributeMagnitudeEvaluatedUpToChannel,
		// Token: 0x04009A8C RID: 39564
		EAttributeBasedFloatCalculationType_MAX
	}
}
