using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200054F RID: 1359
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Element")]
	public enum EKSC_Element : byte
	{
		// Token: 0x04003637 RID: 13879
		Physical,
		// Token: 0x04003638 RID: 13880
		Ice,
		// Token: 0x04003639 RID: 13881
		Fire,
		// Token: 0x0400363A RID: 13882
		Thunder,
		// Token: 0x0400363B RID: 13883
		Wind,
		// Token: 0x0400363C RID: 13884
		Light,
		// Token: 0x0400363D RID: 13885
		Dark,
		// Token: 0x0400363E RID: 13886
		SpecialElement1,
		// Token: 0x0400363F RID: 13887
		SpecialElement2,
		// Token: 0x04003640 RID: 13888
		SpecialElement3,
		// Token: 0x04003641 RID: 13889
		SpecialElement4,
		// Token: 0x04003642 RID: 13890
		SpecialElement5,
		// Token: 0x04003643 RID: 13891
		ElementTypeMax,
		// Token: 0x04003644 RID: 13892
		EKSC_MAX
	}
}
