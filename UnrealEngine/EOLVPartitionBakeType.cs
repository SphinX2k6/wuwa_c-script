using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002923 RID: 10531
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.EOLVPartitionBakeType")]
	public enum EOLVPartitionBakeType : byte
	{
		// Token: 0x040156A3 RID: 87715
		None,
		// Token: 0x040156A4 RID: 87716
		VolumetricLightmap,
		// Token: 0x040156A5 RID: 87717
		SparseVolumeLightingSamples,
		// Token: 0x040156A6 RID: 87718
		EOLVPartitionBakeType_MAX
	}
}
