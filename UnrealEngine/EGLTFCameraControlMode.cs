using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200143B RID: 5179
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GLTFExporter.EGLTFCameraControlMode")]
	public enum EGLTFCameraControlMode : byte
	{
		// Token: 0x0400A1FF RID: 41471
		FreeLook,
		// Token: 0x0400A200 RID: 41472
		Orbital,
		// Token: 0x0400A201 RID: 41473
		EGLTFCameraControlMode_MAX
	}
}
