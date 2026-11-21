using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200037A RID: 890
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroFastCollision.ECollisionShapeKind")]
	public enum ECollisionShapeKind : byte
	{
		// Token: 0x04002551 RID: 9553
		Sphere,
		// Token: 0x04002552 RID: 9554
		Box,
		// Token: 0x04002553 RID: 9555
		Capsule,
		// Token: 0x04002554 RID: 9556
		Cone,
		// Token: 0x04002555 RID: 9557
		ECollisionShapeKind_MAX
	}
}
