using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200149B RID: 5275
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EPDGBakeSelectionOption")]
	public enum EPDGBakeSelectionOption : byte
	{
		// Token: 0x0400A4FF RID: 42239
		All,
		// Token: 0x0400A500 RID: 42240
		SelectedNetwork,
		// Token: 0x0400A501 RID: 42241
		SelectedNode,
		// Token: 0x0400A502 RID: 42242
		EPDGBakeSelectionOption_MAX
	}
}
