using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B7D RID: 2941
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStreamingSourceTargetState")]
	public enum EStreamingSourceTargetState : byte
	{
		// Token: 0x040050F9 RID: 20729
		Loaded,
		// Token: 0x040050FA RID: 20730
		Activated,
		// Token: 0x040050FB RID: 20731
		EStreamingSourceTargetState_MAX
	}
}
