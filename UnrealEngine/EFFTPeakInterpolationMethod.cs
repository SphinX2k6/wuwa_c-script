using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A6A RID: 2666
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFFTPeakInterpolationMethod")]
	public enum EFFTPeakInterpolationMethod : byte
	{
		// Token: 0x04004789 RID: 18313
		NearestNeighbor,
		// Token: 0x0400478A RID: 18314
		Linear,
		// Token: 0x0400478B RID: 18315
		Quadratic,
		// Token: 0x0400478C RID: 18316
		ConstantQ,
		// Token: 0x0400478D RID: 18317
		EFFTPeakInterpolationMethod_MAX
	}
}
