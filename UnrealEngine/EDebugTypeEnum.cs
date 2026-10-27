using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000440 RID: 1088
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ChaosNiagara.EDebugTypeEnum")]
	public enum EDebugTypeEnum : byte
	{
		// Token: 0x04001AE0 RID: 6880
		ChaosNiagara_DebugType_NoDebug,
		// Token: 0x04001AE1 RID: 6881
		ChaosNiagara_DebugType_ColorBySolver,
		// Token: 0x04001AE2 RID: 6882
		ChaosNiagara_DebugType_ColorByParticleIndex,
		// Token: 0x04001AE3 RID: 6883
		ChaosNiagara_Max,
		// Token: 0x04001AE4 RID: 6884
		ChaosNiagara_MAX
	}
}
