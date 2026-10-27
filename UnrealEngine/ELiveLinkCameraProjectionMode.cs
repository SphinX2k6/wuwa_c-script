using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021EE RID: 8686
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LiveLinkInterface.ELiveLinkCameraProjectionMode")]
	public enum ELiveLinkCameraProjectionMode : byte
	{
		// Token: 0x04011AD3 RID: 72403
		Perspective,
		// Token: 0x04011AD4 RID: 72404
		Orthographic,
		// Token: 0x04011AD5 RID: 72405
		ELiveLinkCameraProjectionMode_MAX
	}
}
