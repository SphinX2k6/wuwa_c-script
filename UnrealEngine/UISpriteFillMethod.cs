using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021BE RID: 8638
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UISpriteFillMethod")]
	public enum UISpriteFillMethod : byte
	{
		// Token: 0x040118E5 RID: 71909
		Horizontal,
		// Token: 0x040118E6 RID: 71910
		Vertical,
		// Token: 0x040118E7 RID: 71911
		Radial90,
		// Token: 0x040118E8 RID: 71912
		Radial180,
		// Token: 0x040118E9 RID: 71913
		Radial360,
		// Token: 0x040118EA RID: 71914
		UISpriteFillMethod_MAX
	}
}
