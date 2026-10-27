using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A2E RID: 10798
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EPhysAssetFitGeomType")]
	public enum EPhysAssetFitGeomType
	{
		// Token: 0x04015E52 RID: 89682
		EFG_Box,
		// Token: 0x04015E53 RID: 89683
		EFG_Sphyl,
		// Token: 0x04015E54 RID: 89684
		EFG_Sphere,
		// Token: 0x04015E55 RID: 89685
		EFG_TaperedCapsule,
		// Token: 0x04015E56 RID: 89686
		EFG_SingleConvexHull,
		// Token: 0x04015E57 RID: 89687
		EFG_MultiConvexHull,
		// Token: 0x04015E58 RID: 89688
		EFG_MAX
	}
}
