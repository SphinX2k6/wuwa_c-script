using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000202 RID: 514
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStreamingSourceTargetBehavior")]
	public enum EStreamingSourceTargetBehavior : byte
	{
		// Token: 0x04000CCA RID: 3274
		Include,
		// Token: 0x04000CCB RID: 3275
		Exclude,
		// Token: 0x04000CCC RID: 3276
		EStreamingSourceTargetBehavior_MAX
	}
}
