using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E7A RID: 7802
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSpatialDataBuild.EKuroNavProbeMode")]
	public enum EKuroNavProbeMode : byte
	{
		// Token: 0x04010152 RID: 65874
		Default,
		// Token: 0x04010153 RID: 65875
		Water,
		// Token: 0x04010154 RID: 65876
		EKuroNavProbeMode_MAX
	}
}
