using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA0 RID: 2720
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELevelInstanceRuntimeBehavior")]
	public enum ELevelInstanceRuntimeBehavior : byte
	{
		// Token: 0x04004919 RID: 18713
		None,
		// Token: 0x0400491A RID: 18714
		Embedded_Deprecated,
		// Token: 0x0400491B RID: 18715
		Partitioned,
		// Token: 0x0400491C RID: 18716
		LevelStreaming,
		// Token: 0x0400491D RID: 18717
		ELevelInstanceRuntimeBehavior_MAX
	}
}
