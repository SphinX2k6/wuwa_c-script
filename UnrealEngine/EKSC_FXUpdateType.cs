using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CCB RID: 7371
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_FXUpdateType")]
	public enum EKSC_FXUpdateType : byte
	{
		// Token: 0x0400F662 RID: 63074
		Line,
		// Token: 0x0400F663 RID: 63075
		Target,
		// Token: 0x0400F664 RID: 63076
		Pierce,
		// Token: 0x0400F665 RID: 63077
		EKSC_MAX
	}
}
