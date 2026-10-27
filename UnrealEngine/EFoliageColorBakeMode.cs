using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012C3 RID: 4803
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/FoliageEdit.EFoliageColorBakeMode")]
	public enum EFoliageColorBakeMode
	{
		// Token: 0x040096A2 RID: 38562
		FCB_Cover,
		// Token: 0x040096A3 RID: 38563
		FCB_Blend,
		// Token: 0x040096A4 RID: 38564
		FCB_Add,
		// Token: 0x040096A5 RID: 38565
		FCB_MAX
	}
}
