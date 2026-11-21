using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000100 RID: 256
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EMouseCursor")]
	public enum EMouseCursor
	{
		// Token: 0x04000463 RID: 1123
		None,
		// Token: 0x04000464 RID: 1124
		Default,
		// Token: 0x04000465 RID: 1125
		TextEditBeam,
		// Token: 0x04000466 RID: 1126
		ResizeLeftRight,
		// Token: 0x04000467 RID: 1127
		ResizeUpDown,
		// Token: 0x04000468 RID: 1128
		ResizeSouthEast,
		// Token: 0x04000469 RID: 1129
		ResizeSouthWest,
		// Token: 0x0400046A RID: 1130
		CardinalCross,
		// Token: 0x0400046B RID: 1131
		Crosshairs,
		// Token: 0x0400046C RID: 1132
		Hand,
		// Token: 0x0400046D RID: 1133
		GrabHand,
		// Token: 0x0400046E RID: 1134
		GrabHandClosed,
		// Token: 0x0400046F RID: 1135
		SlashedCircle,
		// Token: 0x04000470 RID: 1136
		EyeDropper,
		// Token: 0x04000471 RID: 1137
		CursorPress = 15,
		// Token: 0x04000472 RID: 1138
		CursorEnter,
		// Token: 0x04000473 RID: 1139
		EMouseCursor_MAX
	}
}
