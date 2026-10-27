using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003E4 RID: 996
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARFaceTrackingUpdate")]
	public enum EARFaceTrackingUpdate : byte
	{
		// Token: 0x04001862 RID: 6242
		CurvesAndGeo,
		// Token: 0x04001863 RID: 6243
		CurvesOnly,
		// Token: 0x04001864 RID: 6244
		EARFaceTrackingUpdate_MAX
	}
}
