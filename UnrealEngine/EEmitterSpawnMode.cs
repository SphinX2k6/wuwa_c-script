using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016D7 RID: 5847
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EEmitterSpawnMode")]
	public enum EEmitterSpawnMode : byte
	{
		// Token: 0x0400B84C RID: 47180
		AtPatternStart,
		// Token: 0x0400B84D RID: 47181
		DelayAfterEmitterStart,
		// Token: 0x0400B84E RID: 47182
		OnEmitterFinished,
		// Token: 0x0400B84F RID: 47183
		OnEmitterFireCountExhausted,
		// Token: 0x0400B850 RID: 47184
		EEmitterSpawnMode_MAX
	}
}
