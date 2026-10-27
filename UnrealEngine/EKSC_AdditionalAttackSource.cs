using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CB5 RID: 7349
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_AdditionalAttackSource")]
	public enum EKSC_AdditionalAttackSource : byte
	{
		// Token: 0x0400F513 RID: 62739
		Source,
		// Token: 0x0400F514 RID: 62740
		Target,
		// Token: 0x0400F515 RID: 62741
		EKSC_MAX
	}
}
