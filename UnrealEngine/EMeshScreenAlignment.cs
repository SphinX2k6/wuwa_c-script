using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ACE RID: 2766
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMeshScreenAlignment")]
	public enum EMeshScreenAlignment
	{
		// Token: 0x04004A9F RID: 19103
		PSMA_MeshFaceCameraWithRoll,
		// Token: 0x04004AA0 RID: 19104
		PSMA_MeshFaceCameraWithSpin,
		// Token: 0x04004AA1 RID: 19105
		PSMA_MeshFaceCameraWithLockedAxis,
		// Token: 0x04004AA2 RID: 19106
		PSMA_MAX
	}
}
