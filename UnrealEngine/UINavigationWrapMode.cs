using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000718 RID: 1816
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UINavigationWrapMode")]
	public enum UINavigationWrapMode : byte
	{
		// Token: 0x04004350 RID: 17232
		None,
		// Token: 0x04004351 RID: 17233
		Wrap,
		// Token: 0x04004352 RID: 17234
		Next,
		// Token: 0x04004353 RID: 17235
		UINavigationWrapMode_MAX
	}
}
