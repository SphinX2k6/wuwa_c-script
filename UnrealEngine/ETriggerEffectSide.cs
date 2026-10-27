using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200292A RID: 10538
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TriggerEffect.ETriggerEffectSide")]
	public enum ETriggerEffectSide : byte
	{
		// Token: 0x040156CA RID: 87754
		Left,
		// Token: 0x040156CB RID: 87755
		Right,
		// Token: 0x040156CC RID: 87756
		Both,
		// Token: 0x040156CD RID: 87757
		TriggerEffectSide_Count,
		// Token: 0x040156CE RID: 87758
		ETriggerEffectSide_MAX
	}
}
