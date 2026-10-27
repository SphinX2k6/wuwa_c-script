using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001690 RID: 5776
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAudio.EAudioFadeCurve")]
	public enum EAudioFadeCurve : byte
	{
		// Token: 0x0400B6A9 RID: 46761
		Log3,
		// Token: 0x0400B6AA RID: 46762
		Sine,
		// Token: 0x0400B6AB RID: 46763
		Log1,
		// Token: 0x0400B6AC RID: 46764
		InvSCurve,
		// Token: 0x0400B6AD RID: 46765
		Linear,
		// Token: 0x0400B6AE RID: 46766
		SCurve,
		// Token: 0x0400B6AF RID: 46767
		Exp1,
		// Token: 0x0400B6B0 RID: 46768
		SineRecip,
		// Token: 0x0400B6B1 RID: 46769
		Exp3,
		// Token: 0x0400B6B2 RID: 46770
		EAudioFadeCurve_MAX
	}
}
