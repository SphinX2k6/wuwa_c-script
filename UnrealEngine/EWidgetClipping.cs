using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002812 RID: 10258
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EWidgetClipping")]
	public enum EWidgetClipping : byte
	{
		// Token: 0x04014E10 RID: 85520
		Inherit,
		// Token: 0x04014E11 RID: 85521
		ClipToBounds,
		// Token: 0x04014E12 RID: 85522
		ClipToBoundsWithoutIntersecting,
		// Token: 0x04014E13 RID: 85523
		ClipToBoundsAlways,
		// Token: 0x04014E14 RID: 85524
		OnDemand,
		// Token: 0x04014E15 RID: 85525
		EWidgetClipping_MAX
	}
}
