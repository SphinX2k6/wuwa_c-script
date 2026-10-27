using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200027D RID: 637
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkUnrealAudioRouting")]
	public enum EAkUnrealAudioRouting
	{
		// Token: 0x04000D88 RID: 3464
		Custom,
		// Token: 0x04000D89 RID: 3465
		Separate,
		// Token: 0x04000D8A RID: 3466
		AudioLink,
		// Token: 0x04000D8B RID: 3467
		AudioMixer,
		// Token: 0x04000D8C RID: 3468
		EnableWwiseOnly,
		// Token: 0x04000D8D RID: 3469
		EnableUnrealOnly,
		// Token: 0x04000D8E RID: 3470
		EAkUnrealAudioRouting_MAX
	}
}
