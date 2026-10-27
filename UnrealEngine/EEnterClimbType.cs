using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200163D RID: 5693
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EEnterClimbType")]
	public enum EEnterClimbType : byte
	{
		// Token: 0x0400B330 RID: 45872
		Air,
		// Token: 0x0400B331 RID: 45873
		Water,
		// Token: 0x0400B332 RID: 45874
		Ground,
		// Token: 0x0400B333 RID: 45875
		Down,
		// Token: 0x0400B334 RID: 45876
		Skill,
		// Token: 0x0400B335 RID: 45877
		EEnterClimbType_MAX
	}
}
