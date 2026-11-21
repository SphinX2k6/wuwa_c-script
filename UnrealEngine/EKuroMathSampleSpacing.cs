using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200045A RID: 1114
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMath.EKuroMathSampleSpacing")]
	public enum EKuroMathSampleSpacing : byte
	{
		// Token: 0x04002D9D RID: 11677
		UniformDistance,
		// Token: 0x04002D9E RID: 11678
		UniformTime,
		// Token: 0x04002D9F RID: 11679
		ErrorTolerance,
		// Token: 0x04002DA0 RID: 11680
		OriginPoints,
		// Token: 0x04002DA1 RID: 11681
		EKuroMathSampleSpacing_MAX
	}
}
