using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CD9 RID: 7385
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_SearchType")]
	public enum EKSC_SearchType : byte
	{
		// Token: 0x0400F6AE RID: 63150
		SearchType0,
		// Token: 0x0400F6AF RID: 63151
		SearchType1,
		// Token: 0x0400F6B0 RID: 63152
		SearchType2,
		// Token: 0x0400F6B1 RID: 63153
		SearchType3 = 4,
		// Token: 0x0400F6B2 RID: 63154
		SearchType4 = 8,
		// Token: 0x0400F6B3 RID: 63155
		SearchType5 = 16,
		// Token: 0x0400F6B4 RID: 63156
		SearchType6 = 32,
		// Token: 0x0400F6B5 RID: 63157
		SearchType7 = 64,
		// Token: 0x0400F6B6 RID: 63158
		SearchType8 = 128,
		// Token: 0x0400F6B7 RID: 63159
		EKSC_MAX
	}
}
