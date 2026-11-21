using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004AC RID: 1196
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroUI3DState")]
	public enum EKuroUI3DState : byte
	{
		// Token: 0x04002FD3 RID: 12243
		NotLoaded,
		// Token: 0x04002FD4 RID: 12244
		Loading,
		// Token: 0x04002FD5 RID: 12245
		Loaded,
		// Token: 0x04002FD6 RID: 12246
		EKuroUI3DState_MAX
	}
}
