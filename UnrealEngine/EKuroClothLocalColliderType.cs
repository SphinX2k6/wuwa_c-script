using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200177C RID: 6012
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EKuroClothLocalColliderType")]
	public enum EKuroClothLocalColliderType : byte
	{
		// Token: 0x0400BCDB RID: 48347
		Sphere,
		// Token: 0x0400BCDC RID: 48348
		Box,
		// Token: 0x0400BCDD RID: 48349
		Cylinder,
		// Token: 0x0400BCDE RID: 48350
		EKuroClothLocalColliderType_MAX
	}
}
