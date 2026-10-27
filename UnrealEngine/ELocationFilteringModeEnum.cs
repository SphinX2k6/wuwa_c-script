using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000441 RID: 1089
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ChaosNiagara.ELocationFilteringModeEnum")]
	public enum ELocationFilteringModeEnum : byte
	{
		// Token: 0x04001AE6 RID: 6886
		ChaosNiagara_LocationFilteringMode_Inclusive,
		// Token: 0x04001AE7 RID: 6887
		ChaosNiagara_LocationFilteringMode_Exclusive,
		// Token: 0x04001AE8 RID: 6888
		ChaosNiagara_Max,
		// Token: 0x04001AE9 RID: 6889
		ChaosNiagara_MAX
	}
}
