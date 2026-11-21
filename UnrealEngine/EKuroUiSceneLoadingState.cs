using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004AD RID: 1197
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroUiSceneLoadingState")]
	public enum EKuroUiSceneLoadingState : byte
	{
		// Token: 0x04002FD8 RID: 12248
		NotLoaded,
		// Token: 0x04002FD9 RID: 12249
		Loading,
		// Token: 0x04002FDA RID: 12250
		LoadedNotVisible,
		// Token: 0x04002FDB RID: 12251
		LoadedAndVisible,
		// Token: 0x04002FDC RID: 12252
		EKuroUiSceneLoadingState_MAX
	}
}
