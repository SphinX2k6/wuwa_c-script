using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000280 RID: 640
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.ERTPCValueType")]
	public enum ERTPCValueType : byte
	{
		// Token: 0x04000DA1 RID: 3489
		Default,
		// Token: 0x04000DA2 RID: 3490
		Global,
		// Token: 0x04000DA3 RID: 3491
		GameObject,
		// Token: 0x04000DA4 RID: 3492
		PlayingID,
		// Token: 0x04000DA5 RID: 3493
		Unavailable,
		// Token: 0x04000DA6 RID: 3494
		ERTPCValueType_MAX
	}
}
