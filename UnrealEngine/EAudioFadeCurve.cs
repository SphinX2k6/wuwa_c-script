using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200030C RID: 780
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAudio.EAudioFadeCurve")]
	public enum EAudioFadeCurve : byte
	{
		// Token: 0x04002204 RID: 8708
		Log3,
		// Token: 0x04002205 RID: 8709
		Sine,
		// Token: 0x04002206 RID: 8710
		Log1,
		// Token: 0x04002207 RID: 8711
		InvSCurve,
		// Token: 0x04002208 RID: 8712
		Linear,
		// Token: 0x04002209 RID: 8713
		SCurve,
		// Token: 0x0400220A RID: 8714
		Exp1,
		// Token: 0x0400220B RID: 8715
		SineRecip,
		// Token: 0x0400220C RID: 8716
		Exp3,
		// Token: 0x0400220D RID: 8717
		EAudioFadeCurve_MAX
	}
}
