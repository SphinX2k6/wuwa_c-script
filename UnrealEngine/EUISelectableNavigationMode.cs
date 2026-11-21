using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200065B RID: 1627
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUISelectableNavigationMode")]
	public enum EUISelectableNavigationMode : byte
	{
		// Token: 0x04003E2E RID: 15918
		None,
		// Token: 0x04003E2F RID: 15919
		Auto,
		// Token: 0x04003E30 RID: 15920
		Explicit,
		// Token: 0x04003E31 RID: 15921
		EUISelectableNavigationMode_MAX
	}
}
