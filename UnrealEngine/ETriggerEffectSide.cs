using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000851 RID: 2129
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TriggerEffect.ETriggerEffectSide")]
	public enum ETriggerEffectSide : byte
	{
		// Token: 0x0400543A RID: 21562
		Left,
		// Token: 0x0400543B RID: 21563
		Right,
		// Token: 0x0400543C RID: 21564
		Both,
		// Token: 0x0400543D RID: 21565
		TriggerEffectSide_Count,
		// Token: 0x0400543E RID: 21566
		ETriggerEffectSide_MAX
	}
}
