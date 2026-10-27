using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A61 RID: 2657
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEmitterNormalsMode")]
	public enum EEmitterNormalsMode
	{
		// Token: 0x0400475B RID: 18267
		ENM_CameraFacing,
		// Token: 0x0400475C RID: 18268
		ENM_Spherical,
		// Token: 0x0400475D RID: 18269
		ENM_Cylindrical,
		// Token: 0x0400475E RID: 18270
		ENM_MAX
	}
}
