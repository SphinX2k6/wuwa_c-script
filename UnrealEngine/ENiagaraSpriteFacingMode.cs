using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002508 RID: 9480
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraSpriteFacingMode")]
	public enum ENiagaraSpriteFacingMode : byte
	{
		// Token: 0x04012E99 RID: 77465
		FaceCamera,
		// Token: 0x04012E9A RID: 77466
		FaceCameraPlane,
		// Token: 0x04012E9B RID: 77467
		CustomFacingVector,
		// Token: 0x04012E9C RID: 77468
		FaceCameraPosition,
		// Token: 0x04012E9D RID: 77469
		FaceCameraDistanceBlend,
		// Token: 0x04012E9E RID: 77470
		ENiagaraSpriteFacingMode_MAX
	}
}
