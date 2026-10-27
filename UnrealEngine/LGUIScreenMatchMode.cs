using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020020B8 RID: 8376
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.LGUIScreenMatchMode")]
	public enum LGUIScreenMatchMode : byte
	{
		// Token: 0x04011094 RID: 69780
		MatchWidthOrHeight,
		// Token: 0x04011095 RID: 69781
		Expand,
		// Token: 0x04011096 RID: 69782
		Shrink,
		// Token: 0x04011097 RID: 69783
		LGUIScreenMatchMode_MAX
	}
}
