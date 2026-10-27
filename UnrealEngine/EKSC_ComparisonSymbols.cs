using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC5 RID: 7365
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ComparisonSymbols")]
	public enum EKSC_ComparisonSymbols : byte
	{
		// Token: 0x0400F62B RID: 63019
		Less,
		// Token: 0x0400F62C RID: 63020
		LessEqual,
		// Token: 0x0400F62D RID: 63021
		Greater,
		// Token: 0x0400F62E RID: 63022
		GreaterEqual,
		// Token: 0x0400F62F RID: 63023
		Equal,
		// Token: 0x0400F630 RID: 63024
		Increase,
		// Token: 0x0400F631 RID: 63025
		Decrease,
		// Token: 0x0400F632 RID: 63026
		EKSC_MAX
	}
}
