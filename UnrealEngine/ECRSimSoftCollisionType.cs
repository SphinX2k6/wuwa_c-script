using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F1 RID: 1265
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ECRSimSoftCollisionType")]
	public enum ECRSimSoftCollisionType : byte
	{
		// Token: 0x04002049 RID: 8265
		Plane,
		// Token: 0x0400204A RID: 8266
		Sphere,
		// Token: 0x0400204B RID: 8267
		Cone,
		// Token: 0x0400204C RID: 8268
		ECRSimSoftCollisionType_MAX
	}
}
