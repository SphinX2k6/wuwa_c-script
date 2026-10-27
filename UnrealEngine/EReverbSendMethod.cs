using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B46 RID: 2886
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EReverbSendMethod")]
	public enum EReverbSendMethod : byte
	{
		// Token: 0x04004F7F RID: 20351
		Linear,
		// Token: 0x04004F80 RID: 20352
		CustomCurve,
		// Token: 0x04004F81 RID: 20353
		Manual,
		// Token: 0x04004F82 RID: 20354
		EReverbSendMethod_MAX
	}
}
