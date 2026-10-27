using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B5B RID: 2907
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESceneCaptureSource")]
	public enum ESceneCaptureSource
	{
		// Token: 0x04004FFA RID: 20474
		SCS_SceneColorHDR,
		// Token: 0x04004FFB RID: 20475
		SCS_SceneColorHDRNoAlpha,
		// Token: 0x04004FFC RID: 20476
		SCS_FinalColorLDR,
		// Token: 0x04004FFD RID: 20477
		SCS_SceneColorSceneDepth,
		// Token: 0x04004FFE RID: 20478
		SCS_SceneDepth,
		// Token: 0x04004FFF RID: 20479
		SCS_DeviceDepth,
		// Token: 0x04005000 RID: 20480
		SCS_Normal,
		// Token: 0x04005001 RID: 20481
		SCS_BaseColor,
		// Token: 0x04005002 RID: 20482
		SCS_BaseColorAndAO,
		// Token: 0x04005003 RID: 20483
		SCS_FinalColorHDR,
		// Token: 0x04005004 RID: 20484
		SCS_FinalToneCurveHDR,
		// Token: 0x04005005 RID: 20485
		SCS_ShadowDepths,
		// Token: 0x04005006 RID: 20486
		SCS_SceneColorHDRAlpha,
		// Token: 0x04005007 RID: 20487
		SCS_MAX
	}
}
