using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019C2 RID: 6594
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMath.EKuroMathSampleSpacing")]
	public enum EKuroMathSampleSpacing : byte
	{
		// Token: 0x0400D3FB RID: 54267
		UniformDistance,
		// Token: 0x0400D3FC RID: 54268
		UniformTime,
		// Token: 0x0400D3FD RID: 54269
		ErrorTolerance,
		// Token: 0x0400D3FE RID: 54270
		OriginPoints,
		// Token: 0x0400D3FF RID: 54271
		EKuroMathSampleSpacing_MAX
	}
}
