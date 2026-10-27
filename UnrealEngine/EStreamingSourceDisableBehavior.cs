using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B7A RID: 2938
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStreamingSourceDisableBehavior")]
	public enum EStreamingSourceDisableBehavior : byte
	{
		// Token: 0x040050EA RID: 20714
		None,
		// Token: 0x040050EB RID: 20715
		Render,
		// Token: 0x040050EC RID: 20716
		EStreamingSourceDisableBehavior_MAX
	}
}
