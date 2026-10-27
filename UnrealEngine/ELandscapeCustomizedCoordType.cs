using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F5A RID: 8026
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ELandscapeCustomizedCoordType")]
	public enum ELandscapeCustomizedCoordType
	{
		// Token: 0x0401075A RID: 67418
		LCCT_None,
		// Token: 0x0401075B RID: 67419
		LCCT_CustomUV0,
		// Token: 0x0401075C RID: 67420
		LCCT_CustomUV1,
		// Token: 0x0401075D RID: 67421
		LCCT_CustomUV2,
		// Token: 0x0401075E RID: 67422
		LCCT_WeightMapUV,
		// Token: 0x0401075F RID: 67423
		LCCT_MAX
	}
}
