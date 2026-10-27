using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003E3 RID: 995
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARFaceTrackingDirection")]
	public enum EARFaceTrackingDirection : byte
	{
		// Token: 0x0400185E RID: 6238
		FaceRelative,
		// Token: 0x0400185F RID: 6239
		FaceMirrored,
		// Token: 0x04001860 RID: 6240
		EARFaceTrackingDirection_MAX
	}
}
