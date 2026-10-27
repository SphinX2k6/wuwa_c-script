using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001484 RID: 5252
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniEngineBakeOption")]
	public enum EHoudiniEngineBakeOption : byte
	{
		// Token: 0x0400A44A RID: 42058
		ToActor,
		// Token: 0x0400A44B RID: 42059
		ToBlueprint,
		// Token: 0x0400A44C RID: 42060
		ToFoliage,
		// Token: 0x0400A44D RID: 42061
		ToWorldOutliner,
		// Token: 0x0400A44E RID: 42062
		EHoudiniEngineBakeOption_MAX
	}
}
