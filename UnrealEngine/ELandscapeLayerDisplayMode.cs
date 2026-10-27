using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F5E RID: 8030
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ELandscapeLayerDisplayMode")]
	public enum ELandscapeLayerDisplayMode : byte
	{
		// Token: 0x04010770 RID: 67440
		Default,
		// Token: 0x04010771 RID: 67441
		Alphabetical,
		// Token: 0x04010772 RID: 67442
		UserSpecific,
		// Token: 0x04010773 RID: 67443
		ELandscapeLayerDisplayMode_MAX
	}
}
