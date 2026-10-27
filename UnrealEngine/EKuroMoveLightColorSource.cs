using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A7D RID: 6781
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroMoveLightColorSource")]
	public enum EKuroMoveLightColorSource : byte
	{
		// Token: 0x0400D9C2 RID: 55746
		SelfColor,
		// Token: 0x0400D9C3 RID: 55747
		BakedCurve,
		// Token: 0x0400D9C4 RID: 55748
		Blend,
		// Token: 0x0400D9C5 RID: 55749
		EKuroMoveLightColorSource_MAX
	}
}
