using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200177D RID: 6013
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EKuroClothTopologyType")]
	public enum EKuroClothTopologyType : byte
	{
		// Token: 0x0400BCE0 RID: 48352
		Grid,
		// Token: 0x0400BCE1 RID: 48353
		TriangleMesh,
		// Token: 0x0400BCE2 RID: 48354
		EKuroClothTopologyType_MAX
	}
}
