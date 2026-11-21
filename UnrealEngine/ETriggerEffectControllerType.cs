using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000850 RID: 2128
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TriggerEffect.ETriggerEffectControllerType")]
	public enum ETriggerEffectControllerType : byte
	{
		// Token: 0x04005434 RID: 21556
		DualSense,
		// Token: 0x04005435 RID: 21557
		Sense,
		// Token: 0x04005436 RID: 21558
		BothControllerTypes,
		// Token: 0x04005437 RID: 21559
		TriggerEffectControllerType_Count,
		// Token: 0x04005438 RID: 21560
		ETriggerEffectControllerType_MAX
	}
}
