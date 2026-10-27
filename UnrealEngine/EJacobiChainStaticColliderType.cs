using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001779 RID: 6009
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EJacobiChainStaticColliderType")]
	public enum EJacobiChainStaticColliderType : byte
	{
		// Token: 0x0400BCCB RID: 48331
		None,
		// Token: 0x0400BCCC RID: 48332
		Box,
		// Token: 0x0400BCCD RID: 48333
		Cylinder,
		// Token: 0x0400BCCE RID: 48334
		Sphere,
		// Token: 0x0400BCCF RID: 48335
		EJacobiChainStaticColliderType_MAX
	}
}
