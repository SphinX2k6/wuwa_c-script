using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A8A RID: 6794
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroUiSceneLoadingState")]
	public enum EKuroUiSceneLoadingState : byte
	{
		// Token: 0x0400DA45 RID: 55877
		NotLoaded,
		// Token: 0x0400DA46 RID: 55878
		Loading,
		// Token: 0x0400DA47 RID: 55879
		LoadedNotVisible,
		// Token: 0x0400DA48 RID: 55880
		LoadedAndVisible,
		// Token: 0x0400DA49 RID: 55881
		EKuroUiSceneLoadingState_MAX
	}
}
