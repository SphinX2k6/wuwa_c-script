using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B80 RID: 2944
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESubmixSendStage")]
	public enum ESubmixSendStage : byte
	{
		// Token: 0x04005109 RID: 20745
		PostDistanceAttenuation,
		// Token: 0x0400510A RID: 20746
		PreDistanceAttenuation,
		// Token: 0x0400510B RID: 20747
		ESubmixSendStage_MAX
	}
}
