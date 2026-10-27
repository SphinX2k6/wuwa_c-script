using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009EB RID: 2539
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimCurveType")]
	public enum EAnimCurveType : byte
	{
		// Token: 0x04004425 RID: 17445
		AttributeCurve,
		// Token: 0x04004426 RID: 17446
		MaterialCurve,
		// Token: 0x04004427 RID: 17447
		MorphTargetCurve,
		// Token: 0x04004428 RID: 17448
		MaxAnimCurveType,
		// Token: 0x04004429 RID: 17449
		EAnimCurveType_MAX
	}
}
