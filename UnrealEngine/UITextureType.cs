using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000738 RID: 1848
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UITextureType")]
	public enum UITextureType : byte
	{
		// Token: 0x040044FB RID: 17659
		Normal,
		// Token: 0x040044FC RID: 17660
		Sliced,
		// Token: 0x040044FD RID: 17661
		SlicedFrame,
		// Token: 0x040044FE RID: 17662
		Tiled,
		// Token: 0x040044FF RID: 17663
		Filled,
		// Token: 0x04004500 RID: 17664
		SlicedEx,
		// Token: 0x04004501 RID: 17665
		UITextureType_MAX
	}
}
