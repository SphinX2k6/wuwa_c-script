using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F0 RID: 9456
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraMeshFacingMode")]
	public enum ENiagaraMeshFacingMode : byte
	{
		// Token: 0x04012E03 RID: 77315
		Default,
		// Token: 0x04012E04 RID: 77316
		Velocity,
		// Token: 0x04012E05 RID: 77317
		CameraPosition,
		// Token: 0x04012E06 RID: 77318
		CameraPlane,
		// Token: 0x04012E07 RID: 77319
		ENiagaraMeshFacingMode_MAX
	}
}
