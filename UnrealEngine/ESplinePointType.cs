using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B76 RID: 2934
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESplinePointType")]
	public enum ESplinePointType
	{
		// Token: 0x040050D3 RID: 20691
		Linear,
		// Token: 0x040050D4 RID: 20692
		Curve,
		// Token: 0x040050D5 RID: 20693
		Constant,
		// Token: 0x040050D6 RID: 20694
		CurveClamped,
		// Token: 0x040050D7 RID: 20695
		CurveCustomTangent,
		// Token: 0x040050D8 RID: 20696
		ESplinePointType_MAX
	}
}
