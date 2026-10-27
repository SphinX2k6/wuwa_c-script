using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000715 RID: 1813
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EInterpCurveMode")]
	public enum EInterpCurveMode
	{
		// Token: 0x04002DD4 RID: 11732
		CIM_Linear,
		// Token: 0x04002DD5 RID: 11733
		CIM_CurveAuto,
		// Token: 0x04002DD6 RID: 11734
		CIM_Constant,
		// Token: 0x04002DD7 RID: 11735
		CIM_CurveUser,
		// Token: 0x04002DD8 RID: 11736
		CIM_CurveBreak,
		// Token: 0x04002DD9 RID: 11737
		CIM_CurveAutoClamped,
		// Token: 0x04002DDA RID: 11738
		CIM_MAX
	}
}
