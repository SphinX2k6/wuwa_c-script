using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200182D RID: 6189
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroFastCollision.EKuroFastCollisionRotationSource")]
	public enum EKuroFastCollisionRotationSource : byte
	{
		// Token: 0x0400C691 RID: 50833
		Manual,
		// Token: 0x0400C692 RID: 50834
		OwnerRoot,
		// Token: 0x0400C693 RID: 50835
		SceneComponent,
		// Token: 0x0400C694 RID: 50836
		EKuroFastCollisionRotationSource_MAX
	}
}
