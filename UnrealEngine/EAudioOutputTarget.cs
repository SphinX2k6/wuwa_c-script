using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009FE RID: 2558
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAudioOutputTarget")]
	public enum EAudioOutputTarget
	{
		// Token: 0x04004493 RID: 17555
		Speaker,
		// Token: 0x04004494 RID: 17556
		Controller,
		// Token: 0x04004495 RID: 17557
		ControllerFallbackToSpeaker,
		// Token: 0x04004496 RID: 17558
		EAudioOutputTarget_MAX
	}
}
