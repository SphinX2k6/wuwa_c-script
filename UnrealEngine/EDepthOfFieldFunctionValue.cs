using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A43 RID: 2627
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDepthOfFieldFunctionValue")]
	public enum EDepthOfFieldFunctionValue
	{
		// Token: 0x04004657 RID: 18007
		TDOF_NearAndFarMask,
		// Token: 0x04004658 RID: 18008
		TDOF_NearMask,
		// Token: 0x04004659 RID: 18009
		TDOF_FarMask,
		// Token: 0x0400465A RID: 18010
		TDOF_CircleOfConfusionRadius,
		// Token: 0x0400465B RID: 18011
		TDOF_MAX
	}
}
