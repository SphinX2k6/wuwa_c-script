using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200182C RID: 6188
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroFastCollision.EKuroFastCollisionCenterSource")]
	public enum EKuroFastCollisionCenterSource : byte
	{
		// Token: 0x0400C68C RID: 50828
		ManualVars,
		// Token: 0x0400C68D RID: 50829
		OwnerRoot,
		// Token: 0x0400C68E RID: 50830
		SceneComponent,
		// Token: 0x0400C68F RID: 50831
		EKuroFastCollisionCenterSource_MAX
	}
}
