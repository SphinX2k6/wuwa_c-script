using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200211F RID: 8479
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIAnchorVerticalAlign")]
	public enum UIAnchorVerticalAlign : byte
	{
		// Token: 0x040112FF RID: 70399
		None,
		// Token: 0x04011300 RID: 70400
		Top,
		// Token: 0x04011301 RID: 70401
		Middle,
		// Token: 0x04011302 RID: 70402
		Bottom,
		// Token: 0x04011303 RID: 70403
		Stretch,
		// Token: 0x04011304 RID: 70404
		UIAnchorVerticalAlign_MAX
	}
}
