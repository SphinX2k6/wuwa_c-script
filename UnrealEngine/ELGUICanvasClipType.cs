using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FDE RID: 8158
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUICanvasClipType")]
	public enum ELGUICanvasClipType : byte
	{
		// Token: 0x04010B65 RID: 68453
		None,
		// Token: 0x04010B66 RID: 68454
		Rect,
		// Token: 0x04010B67 RID: 68455
		Texture,
		// Token: 0x04010B68 RID: 68456
		ELGUICanvasClipType_MAX
	}
}
