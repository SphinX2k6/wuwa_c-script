using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020020F0 RID: 8432
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.NavigationComponentState")]
	public enum NavigationComponentState : byte
	{
		// Token: 0x040111CE RID: 70094
		Select,
		// Token: 0x040111CF RID: 70095
		NoSelect,
		// Token: 0x040111D0 RID: 70096
		Hide,
		// Token: 0x040111D1 RID: 70097
		Show,
		// Token: 0x040111D2 RID: 70098
		NavigationComponentState_MAX
	}
}
