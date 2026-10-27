using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FEC RID: 8172
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EPointerEventType")]
	public enum EPointerEventType : byte
	{
		// Token: 0x04010BBF RID: 68543
		Click,
		// Token: 0x04010BC0 RID: 68544
		Enter,
		// Token: 0x04010BC1 RID: 68545
		Exit,
		// Token: 0x04010BC2 RID: 68546
		Down,
		// Token: 0x04010BC3 RID: 68547
		Up,
		// Token: 0x04010BC4 RID: 68548
		BeginDrag,
		// Token: 0x04010BC5 RID: 68549
		Drag,
		// Token: 0x04010BC6 RID: 68550
		EndDrag,
		// Token: 0x04010BC7 RID: 68551
		Scroll,
		// Token: 0x04010BC8 RID: 68552
		DragEnter_DEPRECATED,
		// Token: 0x04010BC9 RID: 68553
		DragExit_DEPRECATED,
		// Token: 0x04010BCA RID: 68554
		DragDrop,
		// Token: 0x04010BCB RID: 68555
		Select,
		// Token: 0x04010BCC RID: 68556
		Deselect,
		// Token: 0x04010BCD RID: 68557
		Navigate,
		// Token: 0x04010BCE RID: 68558
		Simulation,
		// Token: 0x04010BCF RID: 68559
		EPointerEventType_MAX
	}
}
