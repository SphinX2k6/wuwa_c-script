using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200026F RID: 623
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkAudioSessionMode")]
	public enum EAkAudioSessionMode
	{
		// Token: 0x04000CA5 RID: 3237
		Default,
		// Token: 0x04000CA6 RID: 3238
		VoiceChat,
		// Token: 0x04000CA7 RID: 3239
		GameChat,
		// Token: 0x04000CA8 RID: 3240
		VideoRecording,
		// Token: 0x04000CA9 RID: 3241
		Measurement,
		// Token: 0x04000CAA RID: 3242
		MoviePlayback,
		// Token: 0x04000CAB RID: 3243
		VideoChat,
		// Token: 0x04000CAC RID: 3244
		EAkAudioSessionMode_MAX
	}
}
