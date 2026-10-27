using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000719 RID: 1817
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EMouseCursor")]
	public enum EMouseCursor
	{
		// Token: 0x04002DF9 RID: 11769
		None,
		// Token: 0x04002DFA RID: 11770
		Default,
		// Token: 0x04002DFB RID: 11771
		TextEditBeam,
		// Token: 0x04002DFC RID: 11772
		ResizeLeftRight,
		// Token: 0x04002DFD RID: 11773
		ResizeUpDown,
		// Token: 0x04002DFE RID: 11774
		ResizeSouthEast,
		// Token: 0x04002DFF RID: 11775
		ResizeSouthWest,
		// Token: 0x04002E00 RID: 11776
		CardinalCross,
		// Token: 0x04002E01 RID: 11777
		Crosshairs,
		// Token: 0x04002E02 RID: 11778
		Hand,
		// Token: 0x04002E03 RID: 11779
		GrabHand,
		// Token: 0x04002E04 RID: 11780
		GrabHandClosed,
		// Token: 0x04002E05 RID: 11781
		SlashedCircle,
		// Token: 0x04002E06 RID: 11782
		EyeDropper,
		// Token: 0x04002E07 RID: 11783
		CursorPress = 15,
		// Token: 0x04002E08 RID: 11784
		CursorEnter,
		// Token: 0x04002E09 RID: 11785
		EMouseCursor_MAX
	}
}
