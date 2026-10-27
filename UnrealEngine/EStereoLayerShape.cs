using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B78 RID: 2936
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStereoLayerShape")]
	public enum EStereoLayerShape
	{
		// Token: 0x040050DF RID: 20703
		SLSH_QuadLayer,
		// Token: 0x040050E0 RID: 20704
		SLSH_CylinderLayer,
		// Token: 0x040050E1 RID: 20705
		SLSH_CubemapLayer,
		// Token: 0x040050E2 RID: 20706
		SLSH_EquirectLayer,
		// Token: 0x040050E3 RID: 20707
		SLSH_MAX
	}
}
