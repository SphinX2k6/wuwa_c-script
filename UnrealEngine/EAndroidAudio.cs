using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002AB RID: 683
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AndroidRuntimeSettings.EAndroidAudio")]
	public enum EAndroidAudio
	{
		// Token: 0x04000EF5 RID: 3829
		Default,
		// Token: 0x04000EF6 RID: 3830
		OGG,
		// Token: 0x04000EF7 RID: 3831
		ADPCM,
		// Token: 0x04000EF8 RID: 3832
		EAndroidAudio_MAX
	}
}
