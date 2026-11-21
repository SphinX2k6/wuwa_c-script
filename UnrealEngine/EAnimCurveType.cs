using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001CA RID: 458
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimCurveType")]
	public enum EAnimCurveType : byte
	{
		// Token: 0x04000B2E RID: 2862
		AttributeCurve,
		// Token: 0x04000B2F RID: 2863
		MaterialCurve,
		// Token: 0x04000B30 RID: 2864
		MorphTargetCurve,
		// Token: 0x04000B31 RID: 2865
		MaxAnimCurveType,
		// Token: 0x04000B32 RID: 2866
		EAnimCurveType_MAX
	}
}
