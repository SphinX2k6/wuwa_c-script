using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200026E RID: 622
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkAudioSessionCategory")]
	public enum EAkAudioSessionCategory
	{
		// Token: 0x04000C9F RID: 3231
		Ambient,
		// Token: 0x04000CA0 RID: 3232
		SoloAmbient,
		// Token: 0x04000CA1 RID: 3233
		PlayAndRecord,
		// Token: 0x04000CA2 RID: 3234
		Playback,
		// Token: 0x04000CA3 RID: 3235
		EAkAudioSessionCategory_MAX
	}
}
