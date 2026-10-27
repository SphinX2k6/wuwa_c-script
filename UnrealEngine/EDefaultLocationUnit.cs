using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A15 RID: 10773
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EDefaultLocationUnit")]
	public enum EDefaultLocationUnit : byte
	{
		// Token: 0x04015DA1 RID: 89505
		Micrometers,
		// Token: 0x04015DA2 RID: 89506
		Millimeters,
		// Token: 0x04015DA3 RID: 89507
		Centimeters,
		// Token: 0x04015DA4 RID: 89508
		Meters,
		// Token: 0x04015DA5 RID: 89509
		Kilometers,
		// Token: 0x04015DA6 RID: 89510
		Inches,
		// Token: 0x04015DA7 RID: 89511
		Feet,
		// Token: 0x04015DA8 RID: 89512
		Yards,
		// Token: 0x04015DA9 RID: 89513
		Miles,
		// Token: 0x04015DAA RID: 89514
		Invalid,
		// Token: 0x04015DAB RID: 89515
		EDefaultLocationUnit_MAX
	}
}
