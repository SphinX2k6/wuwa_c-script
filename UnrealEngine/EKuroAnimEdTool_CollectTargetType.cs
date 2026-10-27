using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015FF RID: 5631
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnimEd.EKuroAnimEdTool_CollectTargetType")]
	public enum EKuroAnimEdTool_CollectTargetType : byte
	{
		// Token: 0x0400B067 RID: 45159
		None,
		// Token: 0x0400B068 RID: 45160
		AnimInstanceBP,
		// Token: 0x0400B069 RID: 45161
		LevelSequence_AnimTrace,
		// Token: 0x0400B06A RID: 45162
		MapActor = 4,
		// Token: 0x0400B06B RID: 45163
		ConfigAnim = 8,
		// Token: 0x0400B06C RID: 45164
		ActorBP = 16,
		// Token: 0x0400B06D RID: 45165
		EKuroAnimEdTool_MAX
	}
}
