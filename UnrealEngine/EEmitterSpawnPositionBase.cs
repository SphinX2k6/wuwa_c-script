using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016D8 RID: 5848
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EEmitterSpawnPositionBase")]
	public enum EEmitterSpawnPositionBase : byte
	{
		// Token: 0x0400B852 RID: 47186
		CasterPosition,
		// Token: 0x0400B853 RID: 47187
		SkillTargetPosition,
		// Token: 0x0400B854 RID: 47188
		ParentEmitterPosition,
		// Token: 0x0400B855 RID: 47189
		EEmitterSpawnPositionBase_MAX
	}
}
