using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003FD RID: 1021
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EFaceComponentDebugMode")]
	public enum EFaceComponentDebugMode : byte
	{
		// Token: 0x0400190D RID: 6413
		None,
		// Token: 0x0400190E RID: 6414
		ShowEyeVectors,
		// Token: 0x0400190F RID: 6415
		ShowFaceMesh,
		// Token: 0x04001910 RID: 6416
		EFaceComponentDebugMode_MAX
	}
}
