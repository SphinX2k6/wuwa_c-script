using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001D6 RID: 470
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECollisionEnabled")]
	public enum ECollisionEnabled
	{
		// Token: 0x04000B8D RID: 2957
		NoCollision,
		// Token: 0x04000B8E RID: 2958
		QueryOnly,
		// Token: 0x04000B8F RID: 2959
		PhysicsOnly,
		// Token: 0x04000B90 RID: 2960
		QueryAndPhysics,
		// Token: 0x04000B91 RID: 2961
		ECollisionEnabled_MAX
	}
}
