using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200278C RID: 10124
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EFillMode")]
	public enum EFillMode : byte
	{
		// Token: 0x040149D5 RID: 84437
		Interpolate,
		// Token: 0x040149D6 RID: 84438
		NearestNeighbor,
		// Token: 0x040149D7 RID: 84439
		NoFill,
		// Token: 0x040149D8 RID: 84440
		InterpolateRGBZeroAlpha,
		// Token: 0x040149D9 RID: 84441
		NearestNeighborRGBZeroAlpha,
		// Token: 0x040149DA RID: 84442
		EFillMode_MAX
	}
}
