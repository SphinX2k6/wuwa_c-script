using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002805 RID: 10245
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.ESelectInfo")]
	public enum ESelectInfo
	{
		// Token: 0x04014DBF RID: 85439
		OnKeyPress,
		// Token: 0x04014DC0 RID: 85440
		OnNavigation,
		// Token: 0x04014DC1 RID: 85441
		OnMouseClick,
		// Token: 0x04014DC2 RID: 85442
		Direct,
		// Token: 0x04014DC3 RID: 85443
		ESelectInfo_MAX
	}
}
