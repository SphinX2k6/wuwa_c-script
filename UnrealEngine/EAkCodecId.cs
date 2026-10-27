using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000273 RID: 627
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkCodecId")]
	public enum EAkCodecId : byte
	{
		// Token: 0x04000CE1 RID: 3297
		None,
		// Token: 0x04000CE2 RID: 3298
		PCM,
		// Token: 0x04000CE3 RID: 3299
		ADPCM,
		// Token: 0x04000CE4 RID: 3300
		Vorbis = 4,
		// Token: 0x04000CE5 RID: 3301
		ATRAC9 = 12,
		// Token: 0x04000CE6 RID: 3302
		OpusNX = 17,
		// Token: 0x04000CE7 RID: 3303
		AkOpus = 19,
		// Token: 0x04000CE8 RID: 3304
		AkOpusWEM,
		// Token: 0x04000CE9 RID: 3305
		EAkCodecId_MAX
	}
}
