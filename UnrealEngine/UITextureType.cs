using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021DA RID: 8666
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UITextureType")]
	public enum UITextureType : byte
	{
		// Token: 0x040119F3 RID: 72179
		Normal,
		// Token: 0x040119F4 RID: 72180
		Sliced,
		// Token: 0x040119F5 RID: 72181
		SlicedFrame,
		// Token: 0x040119F6 RID: 72182
		Tiled,
		// Token: 0x040119F7 RID: 72183
		Filled,
		// Token: 0x040119F8 RID: 72184
		SlicedEx,
		// Token: 0x040119F9 RID: 72185
		UITextureType_MAX
	}
}
