using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E7B RID: 7803
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSpatialDataBuild.EKuroNavProbeResult")]
	public enum EKuroNavProbeResult : byte
	{
		// Token: 0x04010156 RID: 65878
		Untested,
		// Token: 0x04010157 RID: 65879
		Pass,
		// Token: 0x04010158 RID: 65880
		Fail,
		// Token: 0x04010159 RID: 65881
		EKuroNavProbeResult_MAX
	}
}
