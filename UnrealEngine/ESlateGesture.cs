using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B68 RID: 2920
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESlateGesture")]
	public enum ESlateGesture : byte
	{
		// Token: 0x0400506B RID: 20587
		None,
		// Token: 0x0400506C RID: 20588
		Scroll,
		// Token: 0x0400506D RID: 20589
		Magnify,
		// Token: 0x0400506E RID: 20590
		Swipe,
		// Token: 0x0400506F RID: 20591
		Rotate,
		// Token: 0x04005070 RID: 20592
		LongPress,
		// Token: 0x04005071 RID: 20593
		ESlateGesture_MAX
	}
}
