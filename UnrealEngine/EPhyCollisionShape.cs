using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015CF RID: 5583
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KawaiiPhysics.EPhyCollisionShape")]
	public enum EPhyCollisionShape : byte
	{
		// Token: 0x0400AF34 RID: 44852
		Spherical,
		// Token: 0x0400AF35 RID: 44853
		Planar,
		// Token: 0x0400AF36 RID: 44854
		Capsule,
		// Token: 0x0400AF37 RID: 44855
		EPhyCollisionShape_MAX
	}
}
