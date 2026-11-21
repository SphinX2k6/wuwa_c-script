using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001FA RID: 506
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESceneCaptureSource")]
	public enum ESceneCaptureSource
	{
		// Token: 0x04000C95 RID: 3221
		SCS_SceneColorHDR,
		// Token: 0x04000C96 RID: 3222
		SCS_SceneColorHDRNoAlpha,
		// Token: 0x04000C97 RID: 3223
		SCS_FinalColorLDR,
		// Token: 0x04000C98 RID: 3224
		SCS_SceneColorSceneDepth,
		// Token: 0x04000C99 RID: 3225
		SCS_SceneDepth,
		// Token: 0x04000C9A RID: 3226
		SCS_DeviceDepth,
		// Token: 0x04000C9B RID: 3227
		SCS_Normal,
		// Token: 0x04000C9C RID: 3228
		SCS_BaseColor,
		// Token: 0x04000C9D RID: 3229
		SCS_BaseColorAndAO,
		// Token: 0x04000C9E RID: 3230
		SCS_FinalColorHDR,
		// Token: 0x04000C9F RID: 3231
		SCS_FinalToneCurveHDR,
		// Token: 0x04000CA0 RID: 3232
		SCS_ShadowDepths,
		// Token: 0x04000CA1 RID: 3233
		SCS_SceneColorHDRAlpha,
		// Token: 0x04000CA2 RID: 3234
		SCS_MAX
	}
}
