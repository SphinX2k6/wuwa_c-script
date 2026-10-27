using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200045E RID: 1118
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EFieldFalloffType")]
	public enum EFieldFalloffType
	{
		// Token: 0x04001BDC RID: 7132
		Field_FallOff_None,
		// Token: 0x04001BDD RID: 7133
		Field_Falloff_Linear,
		// Token: 0x04001BDE RID: 7134
		Field_Falloff_Inverse,
		// Token: 0x04001BDF RID: 7135
		Field_Falloff_Squared,
		// Token: 0x04001BE0 RID: 7136
		Field_Falloff_Logarithmic,
		// Token: 0x04001BE1 RID: 7137
		Field_Falloff_Max
	}
}
