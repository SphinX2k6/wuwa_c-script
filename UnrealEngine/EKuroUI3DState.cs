using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A89 RID: 6793
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroUI3DState")]
	public enum EKuroUI3DState : byte
	{
		// Token: 0x0400DA40 RID: 55872
		NotLoaded,
		// Token: 0x0400DA41 RID: 55873
		Loading,
		// Token: 0x0400DA42 RID: 55874
		Loaded,
		// Token: 0x0400DA43 RID: 55875
		EKuroUI3DState_MAX
	}
}
