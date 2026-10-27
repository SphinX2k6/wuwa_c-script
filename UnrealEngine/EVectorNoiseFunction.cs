using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BAB RID: 2987
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVectorNoiseFunction")]
	public enum EVectorNoiseFunction
	{
		// Token: 0x04005238 RID: 21048
		VNF_CellnoiseALU,
		// Token: 0x04005239 RID: 21049
		VNF_VectorALU,
		// Token: 0x0400523A RID: 21050
		VNF_GradientALU,
		// Token: 0x0400523B RID: 21051
		VNF_CurlALU,
		// Token: 0x0400523C RID: 21052
		VNF_VoronoiALU,
		// Token: 0x0400523D RID: 21053
		VNF_MAX
	}
}
