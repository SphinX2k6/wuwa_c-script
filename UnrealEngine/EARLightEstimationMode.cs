using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003EB RID: 1003
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARLightEstimationMode")]
	public enum EARLightEstimationMode : byte
	{
		// Token: 0x0400188B RID: 6283
		None,
		// Token: 0x0400188C RID: 6284
		AmbientLightEstimate,
		// Token: 0x0400188D RID: 6285
		DirectionalLightEstimate,
		// Token: 0x0400188E RID: 6286
		EARLightEstimationMode_MAX
	}
}
