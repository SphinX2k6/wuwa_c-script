using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F9 RID: 2553
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAttenuationShape")]
	public enum EAttenuationShape
	{
		// Token: 0x04004476 RID: 17526
		Sphere,
		// Token: 0x04004477 RID: 17527
		Capsule,
		// Token: 0x04004478 RID: 17528
		Box,
		// Token: 0x04004479 RID: 17529
		Cone,
		// Token: 0x0400447A RID: 17530
		EAttenuationShape_MAX
	}
}
