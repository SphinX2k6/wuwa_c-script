using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200218E RID: 8590
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UINavigationWrapMode")]
	public enum UINavigationWrapMode : byte
	{
		// Token: 0x040116F3 RID: 71411
		None,
		// Token: 0x040116F4 RID: 71412
		Wrap,
		// Token: 0x040116F5 RID: 71413
		Next,
		// Token: 0x040116F6 RID: 71414
		UINavigationWrapMode_MAX
	}
}
