using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000376 RID: 886
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AudioMixer.ESubmixEffectDynamicsChannelLinkMode")]
	public enum ESubmixEffectDynamicsChannelLinkMode : byte
	{
		// Token: 0x04001530 RID: 5424
		Disabled,
		// Token: 0x04001531 RID: 5425
		Average,
		// Token: 0x04001532 RID: 5426
		Peak,
		// Token: 0x04001533 RID: 5427
		Count,
		// Token: 0x04001534 RID: 5428
		ESubmixEffectDynamicsChannelLinkMode_MAX
	}
}
