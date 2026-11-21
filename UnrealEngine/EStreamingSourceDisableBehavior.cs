using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000200 RID: 512
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStreamingSourceDisableBehavior")]
	public enum EStreamingSourceDisableBehavior : byte
	{
		// Token: 0x04000CBF RID: 3263
		None,
		// Token: 0x04000CC0 RID: 3264
		Render,
		// Token: 0x04000CC1 RID: 3265
		EStreamingSourceDisableBehavior_MAX
	}
}
