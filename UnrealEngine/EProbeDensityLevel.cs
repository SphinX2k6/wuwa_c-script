using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A58 RID: 10840
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/VolumeGIRender.EProbeDensityLevel")]
	public enum EProbeDensityLevel : byte
	{
		// Token: 0x04015F47 RID: 89927
		Level_Low,
		// Token: 0x04015F48 RID: 89928
		Level_Normal,
		// Token: 0x04015F49 RID: 89929
		Level_High,
		// Token: 0x04015F4A RID: 89930
		Level_Ultra,
		// Token: 0x04015F4B RID: 89931
		Level_MAX
	}
}
