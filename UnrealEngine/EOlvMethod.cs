using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AFF RID: 2815
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EOlvMethod")]
	public enum EOlvMethod
	{
		// Token: 0x04004D2F RID: 19759
		OLV_VolumetricLightmap,
		// Token: 0x04004D30 RID: 19760
		OLV_SparseVoxel,
		// Token: 0x04004D31 RID: 19761
		OLV_MAX
	}
}
