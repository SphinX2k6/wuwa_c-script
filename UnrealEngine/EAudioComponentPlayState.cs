using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009FC RID: 2556
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAudioComponentPlayState")]
	public enum EAudioComponentPlayState : byte
	{
		// Token: 0x04004484 RID: 17540
		Playing,
		// Token: 0x04004485 RID: 17541
		Stopped,
		// Token: 0x04004486 RID: 17542
		Paused,
		// Token: 0x04004487 RID: 17543
		FadingIn,
		// Token: 0x04004488 RID: 17544
		FadingOut,
		// Token: 0x04004489 RID: 17545
		Count,
		// Token: 0x0400448A RID: 17546
		EAudioComponentPlayState_MAX
	}
}
