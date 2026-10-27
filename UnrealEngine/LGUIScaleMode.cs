using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020020B7 RID: 8375
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.LGUIScaleMode")]
	public enum LGUIScaleMode : byte
	{
		// Token: 0x04011090 RID: 69776
		ConstantPixelSize,
		// Token: 0x04011091 RID: 69777
		ScaleWithScreenSize,
		// Token: 0x04011092 RID: 69778
		LGUIScaleMode_MAX
	}
}
