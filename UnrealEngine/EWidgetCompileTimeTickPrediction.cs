using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002934 RID: 10548
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMGEditor.EWidgetCompileTimeTickPrediction")]
	public enum EWidgetCompileTimeTickPrediction : byte
	{
		// Token: 0x04015710 RID: 87824
		WontTick,
		// Token: 0x04015711 RID: 87825
		OnDemand,
		// Token: 0x04015712 RID: 87826
		WillTick,
		// Token: 0x04015713 RID: 87827
		EWidgetCompileTimeTickPrediction_MAX
	}
}
