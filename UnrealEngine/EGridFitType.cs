using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FDA RID: 8154
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EGridFitType")]
	public enum EGridFitType : byte
	{
		// Token: 0x04010B48 RID: 68424
		EFT_None,
		// Token: 0x04010B49 RID: 68425
		EFT_HeightWidthFit,
		// Token: 0x04010B4A RID: 68426
		EFT_HeightFit,
		// Token: 0x04010B4B RID: 68427
		EFT_WidthFit,
		// Token: 0x04010B4C RID: 68428
		EFT_FillByLast,
		// Token: 0x04010B4D RID: 68429
		EFT_MAX
	}
}
