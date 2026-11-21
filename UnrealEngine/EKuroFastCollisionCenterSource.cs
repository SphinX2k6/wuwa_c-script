using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200037B RID: 891
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroFastCollision.EKuroFastCollisionCenterSource")]
	public enum EKuroFastCollisionCenterSource : byte
	{
		// Token: 0x04002557 RID: 9559
		ManualVars,
		// Token: 0x04002558 RID: 9560
		OwnerRoot,
		// Token: 0x04002559 RID: 9561
		SceneComponent,
		// Token: 0x0400255A RID: 9562
		EKuroFastCollisionCenterSource_MAX
	}
}
