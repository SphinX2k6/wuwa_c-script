using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015CE RID: 5582
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KawaiiPhysics.ECollisionLimitType")]
	public enum ECollisionLimitType : byte
	{
		// Token: 0x0400AF2E RID: 44846
		None,
		// Token: 0x0400AF2F RID: 44847
		Spherical,
		// Token: 0x0400AF30 RID: 44848
		Capsule,
		// Token: 0x0400AF31 RID: 44849
		Planar,
		// Token: 0x0400AF32 RID: 44850
		ECollisionLimitType_MAX
	}
}
