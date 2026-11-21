using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000FE RID: 254
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EInterpCurveMode")]
	public enum EInterpCurveMode
	{
		// Token: 0x04000456 RID: 1110
		CIM_Linear,
		// Token: 0x04000457 RID: 1111
		CIM_CurveAuto,
		// Token: 0x04000458 RID: 1112
		CIM_Constant,
		// Token: 0x04000459 RID: 1113
		CIM_CurveUser,
		// Token: 0x0400045A RID: 1114
		CIM_CurveBreak,
		// Token: 0x0400045B RID: 1115
		CIM_CurveAutoClamped,
		// Token: 0x0400045C RID: 1116
		CIM_MAX
	}
}
