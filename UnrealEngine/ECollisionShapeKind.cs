using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200182B RID: 6187
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroFastCollision.ECollisionShapeKind")]
	public enum ECollisionShapeKind : byte
	{
		// Token: 0x0400C686 RID: 50822
		Sphere,
		// Token: 0x0400C687 RID: 50823
		Box,
		// Token: 0x0400C688 RID: 50824
		Capsule,
		// Token: 0x0400C689 RID: 50825
		Cone,
		// Token: 0x0400C68A RID: 50826
		ECollisionShapeKind_MAX
	}
}
