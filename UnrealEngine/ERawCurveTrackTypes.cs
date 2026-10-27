using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B38 RID: 2872
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERawCurveTrackTypes")]
	public enum ERawCurveTrackTypes : byte
	{
		// Token: 0x04004F25 RID: 20261
		RCT_Float,
		// Token: 0x04004F26 RID: 20262
		RCT_Vector,
		// Token: 0x04004F27 RID: 20263
		RCT_Transform,
		// Token: 0x04004F28 RID: 20264
		RCT_MAX
	}
}
