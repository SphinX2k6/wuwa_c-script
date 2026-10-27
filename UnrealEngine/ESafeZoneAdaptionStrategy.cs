using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FEE RID: 8174
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ESafeZoneAdaptionStrategy")]
	public enum ESafeZoneAdaptionStrategy : byte
	{
		// Token: 0x04010BD9 RID: 68569
		ESZAS_NoPadding,
		// Token: 0x04010BDA RID: 68570
		ESZAS_SettledPadding,
		// Token: 0x04010BDB RID: 68571
		ESZAS_SymSettledPadding,
		// Token: 0x04010BDC RID: 68572
		ESZAS_CustomPadding,
		// Token: 0x04010BDD RID: 68573
		ESZAS_MAX
	}
}
