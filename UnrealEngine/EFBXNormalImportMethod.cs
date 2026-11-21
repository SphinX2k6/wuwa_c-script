using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200087A RID: 2170
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXNormalImportMethod")]
	public enum EFBXNormalImportMethod
	{
		// Token: 0x04005574 RID: 21876
		FBXNIM_ComputeNormals,
		// Token: 0x04005575 RID: 21877
		FBXNIM_ImportNormals,
		// Token: 0x04005576 RID: 21878
		FBXNIM_ImportNormalsAndTangents,
		// Token: 0x04005577 RID: 21879
		FBXNIM_MAX
	}
}
