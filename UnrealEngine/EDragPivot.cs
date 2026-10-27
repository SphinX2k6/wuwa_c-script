using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002956 RID: 10582
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EDragPivot")]
	public enum EDragPivot : byte
	{
		// Token: 0x0401587C RID: 88188
		MouseDown,
		// Token: 0x0401587D RID: 88189
		TopLeft,
		// Token: 0x0401587E RID: 88190
		TopCenter,
		// Token: 0x0401587F RID: 88191
		TopRight,
		// Token: 0x04015880 RID: 88192
		CenterLeft,
		// Token: 0x04015881 RID: 88193
		CenterCenter,
		// Token: 0x04015882 RID: 88194
		CenterRight,
		// Token: 0x04015883 RID: 88195
		BottomLeft,
		// Token: 0x04015884 RID: 88196
		BottomCenter,
		// Token: 0x04015885 RID: 88197
		BottomRight,
		// Token: 0x04015886 RID: 88198
		EDragPivot_MAX
	}
}
