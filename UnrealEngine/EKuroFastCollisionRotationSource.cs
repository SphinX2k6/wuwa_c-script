using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200037C RID: 892
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroFastCollision.EKuroFastCollisionRotationSource")]
	public enum EKuroFastCollisionRotationSource : byte
	{
		// Token: 0x0400255C RID: 9564
		Manual,
		// Token: 0x0400255D RID: 9565
		OwnerRoot,
		// Token: 0x0400255E RID: 9566
		SceneComponent,
		// Token: 0x0400255F RID: 9567
		EKuroFastCollisionRotationSource_MAX
	}
}
