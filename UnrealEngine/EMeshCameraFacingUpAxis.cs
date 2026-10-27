using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ACA RID: 2762
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMeshCameraFacingUpAxis")]
	public enum EMeshCameraFacingUpAxis
	{
		// Token: 0x04004A86 RID: 19078
		CameraFacing_NoneUP,
		// Token: 0x04004A87 RID: 19079
		CameraFacing_ZUp,
		// Token: 0x04004A88 RID: 19080
		CameraFacing_NegativeZUp,
		// Token: 0x04004A89 RID: 19081
		CameraFacing_YUp,
		// Token: 0x04004A8A RID: 19082
		CameraFacing_NegativeYUp,
		// Token: 0x04004A8B RID: 19083
		CameraFacing_MAX
	}
}
