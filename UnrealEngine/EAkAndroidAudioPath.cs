using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200026D RID: 621
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkAndroidAudioPath")]
	public enum EAkAndroidAudioPath : uint
	{
		// Token: 0x04000C9A RID: 3226
		Legacy,
		// Token: 0x04000C9B RID: 3227
		LowLatency,
		// Token: 0x04000C9C RID: 3228
		Exclusive,
		// Token: 0x04000C9D RID: 3229
		EAkAndroidAudioPath_MAX
	}
}
