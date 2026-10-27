using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002810 RID: 10256
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EUINavigationRule")]
	public enum EUINavigationRule : byte
	{
		// Token: 0x04014E01 RID: 85505
		Escape,
		// Token: 0x04014E02 RID: 85506
		Explicit,
		// Token: 0x04014E03 RID: 85507
		Wrap,
		// Token: 0x04014E04 RID: 85508
		Stop,
		// Token: 0x04014E05 RID: 85509
		Custom,
		// Token: 0x04014E06 RID: 85510
		CustomBoundary,
		// Token: 0x04014E07 RID: 85511
		Invalid,
		// Token: 0x04014E08 RID: 85512
		EUINavigationRule_MAX
	}
}
