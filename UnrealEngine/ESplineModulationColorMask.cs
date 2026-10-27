using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F61 RID: 8033
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ESplineModulationColorMask")]
	public enum ESplineModulationColorMask : byte
	{
		// Token: 0x04010780 RID: 67456
		Red,
		// Token: 0x04010781 RID: 67457
		Green,
		// Token: 0x04010782 RID: 67458
		Blue,
		// Token: 0x04010783 RID: 67459
		Alpha,
		// Token: 0x04010784 RID: 67460
		ESplineModulationColorMask_MAX
	}
}
