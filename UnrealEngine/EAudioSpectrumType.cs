using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A01 RID: 2561
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAudioSpectrumType")]
	public enum EAudioSpectrumType : byte
	{
		// Token: 0x040044A2 RID: 17570
		MagnitudeSpectrum,
		// Token: 0x040044A3 RID: 17571
		PowerSpectrum,
		// Token: 0x040044A4 RID: 17572
		Decibel,
		// Token: 0x040044A5 RID: 17573
		EAudioSpectrumType_MAX
	}
}
