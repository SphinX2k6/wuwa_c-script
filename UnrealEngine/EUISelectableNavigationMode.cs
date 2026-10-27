using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200200B RID: 8203
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUISelectableNavigationMode")]
	public enum EUISelectableNavigationMode : byte
	{
		// Token: 0x04010CA6 RID: 68774
		None,
		// Token: 0x04010CA7 RID: 68775
		Auto,
		// Token: 0x04010CA8 RID: 68776
		Explicit,
		// Token: 0x04010CA9 RID: 68777
		EUISelectableNavigationMode_MAX
	}
}
