using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002929 RID: 10537
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TriggerEffect.ETriggerEffectControllerType")]
	public enum ETriggerEffectControllerType : byte
	{
		// Token: 0x040156C4 RID: 87748
		DualSense,
		// Token: 0x040156C5 RID: 87749
		Sense,
		// Token: 0x040156C6 RID: 87750
		BothControllerTypes,
		// Token: 0x040156C7 RID: 87751
		TriggerEffectControllerType_Count,
		// Token: 0x040156C8 RID: 87752
		ETriggerEffectControllerType_MAX
	}
}
