using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A20 RID: 10784
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXSceneNormalImportMethod")]
	public enum EFBXSceneNormalImportMethod : byte
	{
		// Token: 0x04015DFC RID: 89596
		FBXSceneNIM_ComputeNormals,
		// Token: 0x04015DFD RID: 89597
		FBXSceneNIM_ImportNormals,
		// Token: 0x04015DFE RID: 89598
		FBXSceneNIM_ImportNormalsAndTangents,
		// Token: 0x04015DFF RID: 89599
		FBXSceneNIM_MAX
	}
}
