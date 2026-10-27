using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200280D RID: 10253
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.ETextShapingMethod")]
	public enum ETextShapingMethod : byte
	{
		// Token: 0x04014DEC RID: 85484
		Auto,
		// Token: 0x04014DED RID: 85485
		KerningOnly,
		// Token: 0x04014DEE RID: 85486
		FullShaping,
		// Token: 0x04014DEF RID: 85487
		ETextShapingMethod_MAX
	}
}
