using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC9 RID: 2761
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMeshCameraFacingOptions")]
	public enum EMeshCameraFacingOptions
	{
		// Token: 0x04004A77 RID: 19063
		XAxisFacing_NoUp,
		// Token: 0x04004A78 RID: 19064
		XAxisFacing_ZUp,
		// Token: 0x04004A79 RID: 19065
		XAxisFacing_NegativeZUp,
		// Token: 0x04004A7A RID: 19066
		XAxisFacing_YUp,
		// Token: 0x04004A7B RID: 19067
		XAxisFacing_NegativeYUp,
		// Token: 0x04004A7C RID: 19068
		LockedAxis_ZAxisFacing,
		// Token: 0x04004A7D RID: 19069
		LockedAxis_NegativeZAxisFacing,
		// Token: 0x04004A7E RID: 19070
		LockedAxis_YAxisFacing,
		// Token: 0x04004A7F RID: 19071
		LockedAxis_NegativeYAxisFacing,
		// Token: 0x04004A80 RID: 19072
		VelocityAligned_ZAxisFacing,
		// Token: 0x04004A81 RID: 19073
		VelocityAligned_NegativeZAxisFacing,
		// Token: 0x04004A82 RID: 19074
		VelocityAligned_YAxisFacing,
		// Token: 0x04004A83 RID: 19075
		VelocityAligned_NegativeYAxisFacing,
		// Token: 0x04004A84 RID: 19076
		EMeshCameraFacingOptions_MAX
	}
}
