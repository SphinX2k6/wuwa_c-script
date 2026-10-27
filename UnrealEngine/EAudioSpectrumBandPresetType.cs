using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A00 RID: 2560
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAudioSpectrumBandPresetType")]
	public enum EAudioSpectrumBandPresetType : byte
	{
		// Token: 0x0400449C RID: 17564
		KickDrum,
		// Token: 0x0400449D RID: 17565
		SnareDrum,
		// Token: 0x0400449E RID: 17566
		Voice,
		// Token: 0x0400449F RID: 17567
		Cymbals,
		// Token: 0x040044A0 RID: 17568
		EAudioSpectrumBandPresetType_MAX
	}
}
