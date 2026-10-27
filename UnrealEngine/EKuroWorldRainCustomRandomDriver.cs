using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A8B RID: 6795
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroWorldRainCustomRandomDriver")]
	public enum EKuroWorldRainCustomRandomDriver : byte
	{
		// Token: 0x0400DA4B RID: 55883
		CustomRandomDriver_None,
		// Token: 0x0400DA4C RID: 55884
		CustomRandomDriver_NormalizedAge,
		// Token: 0x0400DA4D RID: 55885
		CustomRandomDriver_Velocity,
		// Token: 0x0400DA4E RID: 55886
		CustomRandomDriver_VelocityMultiTimeScale,
		// Token: 0x0400DA4F RID: 55887
		CustomRandomDriver_MAX
	}
}
