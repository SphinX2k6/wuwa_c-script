using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000D1 RID: 209
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkCurveInterpolation")]
	public enum EAkCurveInterpolation : byte
	{
		// Token: 0x0400032C RID: 812
		Log3,
		// Token: 0x0400032D RID: 813
		Sine,
		// Token: 0x0400032E RID: 814
		Log1,
		// Token: 0x0400032F RID: 815
		InvSCurve,
		// Token: 0x04000330 RID: 816
		Linear,
		// Token: 0x04000331 RID: 817
		SCurve,
		// Token: 0x04000332 RID: 818
		Exp1,
		// Token: 0x04000333 RID: 819
		SineRecip,
		// Token: 0x04000334 RID: 820
		Exp3,
		// Token: 0x04000335 RID: 821
		LastFadeCurve = 8,
		// Token: 0x04000336 RID: 822
		Constant,
		// Token: 0x04000337 RID: 823
		EAkCurveInterpolation_MAX
	}
}
