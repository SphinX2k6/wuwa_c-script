using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A25 RID: 10789
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.ELandscapeFoliageEditorControlType")]
	public enum ELandscapeFoliageEditorControlType : byte
	{
		// Token: 0x04015E1D RID: 89629
		IgnoreCtrl,
		// Token: 0x04015E1E RID: 89630
		RequireCtrl,
		// Token: 0x04015E1F RID: 89631
		RequireNoCtrl,
		// Token: 0x04015E20 RID: 89632
		ELandscapeFoliageEditorControlType_MAX
	}
}
