using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FE0 RID: 8160
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUIEventFireType")]
	public enum ELGUIEventFireType : byte
	{
		// Token: 0x04010B6E RID: 68462
		TargetActorAndAllItsComponents,
		// Token: 0x04010B6F RID: 68463
		OnlyTargetComponent,
		// Token: 0x04010B70 RID: 68464
		OnlyTargetActor,
		// Token: 0x04010B71 RID: 68465
		ELGUIEventFireType_MAX
	}
}
