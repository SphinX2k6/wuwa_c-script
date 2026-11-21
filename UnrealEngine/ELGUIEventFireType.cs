using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200064B RID: 1611
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUIEventFireType")]
	public enum ELGUIEventFireType : byte
	{
		// Token: 0x04003DA7 RID: 15783
		TargetActorAndAllItsComponents,
		// Token: 0x04003DA8 RID: 15784
		OnlyTargetComponent,
		// Token: 0x04003DA9 RID: 15785
		OnlyTargetActor,
		// Token: 0x04003DAA RID: 15786
		ELGUIEventFireType_MAX
	}
}
