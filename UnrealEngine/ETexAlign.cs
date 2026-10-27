using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A40 RID: 10816
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.ETexAlign")]
	public enum ETexAlign
	{
		// Token: 0x04015EBB RID: 89787
		TEXALIGN_None,
		// Token: 0x04015EBC RID: 89788
		TEXALIGN_Default,
		// Token: 0x04015EBD RID: 89789
		TEXALIGN_Box,
		// Token: 0x04015EBE RID: 89790
		TEXALIGN_Planar,
		// Token: 0x04015EBF RID: 89791
		TEXALIGN_Fit,
		// Token: 0x04015EC0 RID: 89792
		TEXALIGN_PlanarAuto,
		// Token: 0x04015EC1 RID: 89793
		TEXALIGN_PlanarWall,
		// Token: 0x04015EC2 RID: 89794
		TEXALIGN_PlanarFloor,
		// Token: 0x04015EC3 RID: 89795
		TEXALIGN_MAX
	}
}
