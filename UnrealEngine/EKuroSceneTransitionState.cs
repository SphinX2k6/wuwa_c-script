using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A85 RID: 6789
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroSceneTransitionState")]
	public enum EKuroSceneTransitionState : byte
	{
		// Token: 0x0400DA1E RID: 55838
		Loading,
		// Token: 0x0400DA1F RID: 55839
		Loaded,
		// Token: 0x0400DA20 RID: 55840
		Unloading,
		// Token: 0x0400DA21 RID: 55841
		Unloaded,
		// Token: 0x0400DA22 RID: 55842
		KuroSceneTransitionStateMax,
		// Token: 0x0400DA23 RID: 55843
		EKuroSceneTransitionState_MAX
	}
}
