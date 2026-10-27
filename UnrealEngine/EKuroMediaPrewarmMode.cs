using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A7C RID: 6780
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroMediaPrewarmMode")]
	public enum EKuroMediaPrewarmMode : byte
	{
		// Token: 0x0400D9BE RID: 55742
		Auto,
		// Token: 0x0400D9BF RID: 55743
		Manual,
		// Token: 0x0400D9C0 RID: 55744
		EKuroMediaPrewarmMode_MAX
	}
}
