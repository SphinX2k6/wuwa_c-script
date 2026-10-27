using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AB3 RID: 2739
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialFunctionUsage")]
	public enum EMaterialFunctionUsage : byte
	{
		// Token: 0x04004993 RID: 18835
		Default,
		// Token: 0x04004994 RID: 18836
		MaterialLayer,
		// Token: 0x04004995 RID: 18837
		MaterialLayerBlend,
		// Token: 0x04004996 RID: 18838
		EMaterialFunctionUsage_MAX
	}
}
