using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A1A RID: 10778
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXImportContentType")]
	public enum EFBXImportContentType
	{
		// Token: 0x04015DE1 RID: 89569
		FBXICT_All,
		// Token: 0x04015DE2 RID: 89570
		FBXICT_Geometry,
		// Token: 0x04015DE3 RID: 89571
		FBXICT_SkinningWeights,
		// Token: 0x04015DE4 RID: 89572
		FBXICT_MAX
	}
}
