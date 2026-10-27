using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002304 RID: 8964
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieSceneCapture.EHDRCaptureGamut")]
	public enum EHDRCaptureGamut
	{
		// Token: 0x040121D6 RID: 74198
		HCGM_Rec709,
		// Token: 0x040121D7 RID: 74199
		HCGM_P3DCI,
		// Token: 0x040121D8 RID: 74200
		HCGM_Rec2020,
		// Token: 0x040121D9 RID: 74201
		HCGM_ACES,
		// Token: 0x040121DA RID: 74202
		HCGM_ACEScg,
		// Token: 0x040121DB RID: 74203
		HCGM_Linear,
		// Token: 0x040121DC RID: 74204
		HCGM_MAX
	}
}
