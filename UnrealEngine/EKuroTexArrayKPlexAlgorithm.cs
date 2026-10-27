using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C84 RID: 7300
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSceneToolkit.EKuroTexArrayKPlexAlgorithm")]
	public enum EKuroTexArrayKPlexAlgorithm : byte
	{
		// Token: 0x0400F3B8 RID: 62392
		Undirected,
		// Token: 0x0400F3B9 RID: 62393
		OutDirected,
		// Token: 0x0400F3BA RID: 62394
		InOutDirected,
		// Token: 0x0400F3BB RID: 62395
		EKuroTexArrayKPlexAlgorithm_MAX
	}
}
