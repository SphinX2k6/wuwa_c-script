using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024D5 RID: 9429
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.EKuroBlurCurveTarget")]
	public enum EKuroBlurCurveTarget : byte
	{
		// Token: 0x04012D62 RID: 77154
		BlurRadius,
		// Token: 0x04012D63 RID: 77155
		BlendOpacity,
		// Token: 0x04012D64 RID: 77156
		Both,
		// Token: 0x04012D65 RID: 77157
		EKuroBlurCurveTarget_MAX
	}
}
