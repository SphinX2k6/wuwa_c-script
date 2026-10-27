using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B7C RID: 2940
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStreamingSourceTargetBehavior")]
	public enum EStreamingSourceTargetBehavior : byte
	{
		// Token: 0x040050F5 RID: 20725
		Include,
		// Token: 0x040050F6 RID: 20726
		Exclude,
		// Token: 0x040050F7 RID: 20727
		EStreamingSourceTargetBehavior_MAX
	}
}
