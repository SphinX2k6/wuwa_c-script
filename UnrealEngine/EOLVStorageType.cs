using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002924 RID: 10532
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.EOLVStorageType")]
	public enum EOLVStorageType : byte
	{
		// Token: 0x040156A8 RID: 87720
		VolumetricLightmap,
		// Token: 0x040156A9 RID: 87721
		SparseVoxel,
		// Token: 0x040156AA RID: 87722
		EOLVStorageType_MAX
	}
}
