using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B35 RID: 2869
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EQuarztQuantizationReference")]
	public enum EQuarztQuantizationReference : byte
	{
		// Token: 0x04004F13 RID: 20243
		BarRelative,
		// Token: 0x04004F14 RID: 20244
		TransportRelative,
		// Token: 0x04004F15 RID: 20245
		CurrentTimeRelative,
		// Token: 0x04004F16 RID: 20246
		Count,
		// Token: 0x04004F17 RID: 20247
		EQuarztQuantizationReference_MAX
	}
}
