using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000348 RID: 840
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraph.EBlueprintUsage")]
	public enum EBlueprintUsage : byte
	{
		// Token: 0x04001417 RID: 5143
		NoProperties,
		// Token: 0x04001418 RID: 5144
		DoesNotUseBlueprint,
		// Token: 0x04001419 RID: 5145
		UsesBlueprint,
		// Token: 0x0400141A RID: 5146
		EBlueprintUsage_MAX
	}
}
