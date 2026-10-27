using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A28 RID: 10792
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.ELevelViewportType")]
	public enum ELevelViewportType
	{
		// Token: 0x04015E2A RID: 89642
		LVT_OrthoXY,
		// Token: 0x04015E2B RID: 89643
		LVT_OrthoXZ,
		// Token: 0x04015E2C RID: 89644
		LVT_OrthoYZ,
		// Token: 0x04015E2D RID: 89645
		LVT_Perspective,
		// Token: 0x04015E2E RID: 89646
		LVT_OrthoFreelook,
		// Token: 0x04015E2F RID: 89647
		LVT_OrthoNegativeXY,
		// Token: 0x04015E30 RID: 89648
		LVT_OrthoNegativeXZ,
		// Token: 0x04015E31 RID: 89649
		LVT_OrthoNegativeYZ,
		// Token: 0x04015E32 RID: 89650
		LVT_MAX,
		// Token: 0x04015E33 RID: 89651
		LVT_None = 255
	}
}
