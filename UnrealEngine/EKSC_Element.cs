using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC6 RID: 7366
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Element")]
	public enum EKSC_Element : byte
	{
		// Token: 0x0400F634 RID: 63028
		Physical,
		// Token: 0x0400F635 RID: 63029
		Ice,
		// Token: 0x0400F636 RID: 63030
		Fire,
		// Token: 0x0400F637 RID: 63031
		Thunder,
		// Token: 0x0400F638 RID: 63032
		Wind,
		// Token: 0x0400F639 RID: 63033
		Light,
		// Token: 0x0400F63A RID: 63034
		Dark,
		// Token: 0x0400F63B RID: 63035
		SpecialElement1,
		// Token: 0x0400F63C RID: 63036
		SpecialElement2,
		// Token: 0x0400F63D RID: 63037
		SpecialElement3,
		// Token: 0x0400F63E RID: 63038
		SpecialElement4,
		// Token: 0x0400F63F RID: 63039
		SpecialElement5,
		// Token: 0x0400F640 RID: 63040
		ElementTypeMax,
		// Token: 0x0400F641 RID: 63041
		EKSC_MAX
	}
}
