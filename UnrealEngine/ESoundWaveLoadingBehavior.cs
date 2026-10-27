using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B6D RID: 2925
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESoundWaveLoadingBehavior")]
	public enum ESoundWaveLoadingBehavior : byte
	{
		// Token: 0x0400509F RID: 20639
		Inherited,
		// Token: 0x040050A0 RID: 20640
		RetainOnLoad,
		// Token: 0x040050A1 RID: 20641
		PrimeOnLoad,
		// Token: 0x040050A2 RID: 20642
		LoadOnDemand,
		// Token: 0x040050A3 RID: 20643
		ForceInline,
		// Token: 0x040050A4 RID: 20644
		Uninitialized = 255
	}
}
