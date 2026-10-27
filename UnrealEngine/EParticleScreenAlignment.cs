using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B0E RID: 2830
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleScreenAlignment")]
	public enum EParticleScreenAlignment
	{
		// Token: 0x04004D83 RID: 19843
		PSA_FacingCameraPosition,
		// Token: 0x04004D84 RID: 19844
		PSA_Square,
		// Token: 0x04004D85 RID: 19845
		PSA_Rectangle,
		// Token: 0x04004D86 RID: 19846
		PSA_Velocity,
		// Token: 0x04004D87 RID: 19847
		PSA_AwayFromCenter,
		// Token: 0x04004D88 RID: 19848
		PSA_TypeSpecific,
		// Token: 0x04004D89 RID: 19849
		PSA_FacingCameraDistanceBlend,
		// Token: 0x04004D8A RID: 19850
		PSA_MAX
	}
}
