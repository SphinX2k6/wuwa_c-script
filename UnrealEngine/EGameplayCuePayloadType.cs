using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200133A RID: 4922
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayCuePayloadType")]
	public enum EGameplayCuePayloadType : byte
	{
		// Token: 0x04009AC5 RID: 39621
		CueParameters,
		// Token: 0x04009AC6 RID: 39622
		FromSpec,
		// Token: 0x04009AC7 RID: 39623
		EGameplayCuePayloadType_MAX
	}
}
