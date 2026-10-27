using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200284D RID: 10317
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EProgressBarFillType")]
	public enum EProgressBarFillType
	{
		// Token: 0x04014FCD RID: 85965
		LeftToRight,
		// Token: 0x04014FCE RID: 85966
		RightToLeft,
		// Token: 0x04014FCF RID: 85967
		FillFromCenter,
		// Token: 0x04014FD0 RID: 85968
		TopToBottom,
		// Token: 0x04014FD1 RID: 85969
		BottomToTop,
		// Token: 0x04014FD2 RID: 85970
		EProgressBarFillType_MAX
	}
}
