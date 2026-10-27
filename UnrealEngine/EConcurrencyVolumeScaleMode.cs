using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A33 RID: 2611
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EConcurrencyVolumeScaleMode")]
	public enum EConcurrencyVolumeScaleMode
	{
		// Token: 0x040045E6 RID: 17894
		Default,
		// Token: 0x040045E7 RID: 17895
		Distance,
		// Token: 0x040045E8 RID: 17896
		Priority,
		// Token: 0x040045E9 RID: 17897
		EConcurrencyVolumeScaleMode_MAX
	}
}
