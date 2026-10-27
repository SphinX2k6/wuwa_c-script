using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200026C RID: 620
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkActionOnEventType")]
	public enum EAkActionOnEventType : byte
	{
		// Token: 0x04000C93 RID: 3219
		Stop,
		// Token: 0x04000C94 RID: 3220
		Pause,
		// Token: 0x04000C95 RID: 3221
		Resume,
		// Token: 0x04000C96 RID: 3222
		Break,
		// Token: 0x04000C97 RID: 3223
		ReleaseEnvelope,
		// Token: 0x04000C98 RID: 3224
		EAkActionOnEventType_MAX
	}
}
