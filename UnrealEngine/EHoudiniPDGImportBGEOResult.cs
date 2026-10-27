using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001510 RID: 5392
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngine.EHoudiniPDGImportBGEOResult")]
	public enum EHoudiniPDGImportBGEOResult : byte
	{
		// Token: 0x0400A99E RID: 43422
		HPIBR_Failed,
		// Token: 0x0400A99F RID: 43423
		HPIBR_Success,
		// Token: 0x0400A9A0 RID: 43424
		HPIBR_PartialSuccess,
		// Token: 0x0400A9A1 RID: 43425
		HIBPR_MAX,
		// Token: 0x0400A9A2 RID: 43426
		EHoudiniPDGImportBGEOResult_MAX
	}
}
