using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001C6 RID: 454
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.FAIDistanceType")]
	public enum FAIDistanceType : byte
	{
		// Token: 0x040008A1 RID: 2209
		Distance3D,
		// Token: 0x040008A2 RID: 2210
		Distance2D,
		// Token: 0x040008A3 RID: 2211
		DistanceZ,
		// Token: 0x040008A4 RID: 2212
		MAX
	}
}
