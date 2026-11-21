using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002E7 RID: 743
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EEnterClimbType")]
	public enum EEnterClimbType : byte
	{
		// Token: 0x04002050 RID: 8272
		Air,
		// Token: 0x04002051 RID: 8273
		Water,
		// Token: 0x04002052 RID: 8274
		Ground,
		// Token: 0x04002053 RID: 8275
		Down,
		// Token: 0x04002054 RID: 8276
		Skill,
		// Token: 0x04002055 RID: 8277
		EEnterClimbType_MAX
	}
}
