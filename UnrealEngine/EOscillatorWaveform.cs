using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B04 RID: 2820
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EOscillatorWaveform")]
	public enum EOscillatorWaveform : byte
	{
		// Token: 0x04004D48 RID: 19784
		SineWave,
		// Token: 0x04004D49 RID: 19785
		PerlinNoise,
		// Token: 0x04004D4A RID: 19786
		EOscillatorWaveform_MAX
	}
}
