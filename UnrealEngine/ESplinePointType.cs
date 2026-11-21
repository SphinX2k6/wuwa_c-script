using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001FF RID: 511
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESplinePointType")]
	public enum ESplinePointType
	{
		// Token: 0x04000CB8 RID: 3256
		Linear,
		// Token: 0x04000CB9 RID: 3257
		Curve,
		// Token: 0x04000CBA RID: 3258
		Constant,
		// Token: 0x04000CBB RID: 3259
		CurveClamped,
		// Token: 0x04000CBC RID: 3260
		CurveCustomTangent,
		// Token: 0x04000CBD RID: 3261
		ESplinePointType_MAX
	}
}
