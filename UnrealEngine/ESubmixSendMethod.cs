using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B7F RID: 2943
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESubmixSendMethod")]
	public enum ESubmixSendMethod : byte
	{
		// Token: 0x04005104 RID: 20740
		Linear,
		// Token: 0x04005105 RID: 20741
		CustomCurve,
		// Token: 0x04005106 RID: 20742
		Manual,
		// Token: 0x04005107 RID: 20743
		ESubmixSendMethod_MAX
	}
}
