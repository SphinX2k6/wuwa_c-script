using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200026B RID: 619
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkAcousticPortalState")]
	public enum EAkAcousticPortalState : byte
	{
		// Token: 0x04000C8F RID: 3215
		Closed,
		// Token: 0x04000C90 RID: 3216
		Open,
		// Token: 0x04000C91 RID: 3217
		EAkAcousticPortalState_MAX
	}
}
