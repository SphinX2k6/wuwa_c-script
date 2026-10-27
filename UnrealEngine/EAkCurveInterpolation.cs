using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000276 RID: 630
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkCurveInterpolation")]
	public enum EAkCurveInterpolation : byte
	{
		// Token: 0x04000CFA RID: 3322
		Log3,
		// Token: 0x04000CFB RID: 3323
		Sine,
		// Token: 0x04000CFC RID: 3324
		Log1,
		// Token: 0x04000CFD RID: 3325
		InvSCurve,
		// Token: 0x04000CFE RID: 3326
		Linear,
		// Token: 0x04000CFF RID: 3327
		SCurve,
		// Token: 0x04000D00 RID: 3328
		Exp1,
		// Token: 0x04000D01 RID: 3329
		SineRecip,
		// Token: 0x04000D02 RID: 3330
		Exp3,
		// Token: 0x04000D03 RID: 3331
		LastFadeCurve = 8,
		// Token: 0x04000D04 RID: 3332
		Constant,
		// Token: 0x04000D05 RID: 3333
		EAkCurveInterpolation_MAX
	}
}
