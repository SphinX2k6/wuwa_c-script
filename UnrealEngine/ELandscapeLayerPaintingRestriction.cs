using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F5F RID: 8031
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ELandscapeLayerPaintingRestriction")]
	public enum ELandscapeLayerPaintingRestriction : byte
	{
		// Token: 0x04010775 RID: 67445
		None,
		// Token: 0x04010776 RID: 67446
		UseMaxLayers,
		// Token: 0x04010777 RID: 67447
		ExistingOnly,
		// Token: 0x04010778 RID: 67448
		UseComponentWhitelist,
		// Token: 0x04010779 RID: 67449
		KuroLayerConstraint,
		// Token: 0x0401077A RID: 67450
		ELandscapeLayerPaintingRestriction_MAX
	}
}
