using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012C4 RID: 4804
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Foliage.EFoliageScaling")]
	public enum EFoliageScaling : byte
	{
		// Token: 0x040096A7 RID: 38567
		Uniform,
		// Token: 0x040096A8 RID: 38568
		Free,
		// Token: 0x040096A9 RID: 38569
		LockXY,
		// Token: 0x040096AA RID: 38570
		LockXZ,
		// Token: 0x040096AB RID: 38571
		LockYZ,
		// Token: 0x040096AC RID: 38572
		EFoliageScaling_MAX
	}
}
