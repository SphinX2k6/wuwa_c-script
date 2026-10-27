using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A1E RID: 10782
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXNormalImportMethod")]
	public enum EFBXNormalImportMethod
	{
		// Token: 0x04015DF3 RID: 89587
		FBXNIM_ComputeNormals,
		// Token: 0x04015DF4 RID: 89588
		FBXNIM_ImportNormals,
		// Token: 0x04015DF5 RID: 89589
		FBXNIM_ImportNormalsAndTangents,
		// Token: 0x04015DF6 RID: 89590
		FBXNIM_MAX
	}
}
