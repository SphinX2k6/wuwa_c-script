using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000651 RID: 1617
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EPointerEventType")]
	public enum EPointerEventType : byte
	{
		// Token: 0x04003DD8 RID: 15832
		Click,
		// Token: 0x04003DD9 RID: 15833
		Enter,
		// Token: 0x04003DDA RID: 15834
		Exit,
		// Token: 0x04003DDB RID: 15835
		Down,
		// Token: 0x04003DDC RID: 15836
		Up,
		// Token: 0x04003DDD RID: 15837
		BeginDrag,
		// Token: 0x04003DDE RID: 15838
		Drag,
		// Token: 0x04003DDF RID: 15839
		EndDrag,
		// Token: 0x04003DE0 RID: 15840
		Scroll,
		// Token: 0x04003DE1 RID: 15841
		DragEnter_DEPRECATED,
		// Token: 0x04003DE2 RID: 15842
		DragExit_DEPRECATED,
		// Token: 0x04003DE3 RID: 15843
		DragDrop,
		// Token: 0x04003DE4 RID: 15844
		Select,
		// Token: 0x04003DE5 RID: 15845
		Deselect,
		// Token: 0x04003DE6 RID: 15846
		Navigate,
		// Token: 0x04003DE7 RID: 15847
		Simulation,
		// Token: 0x04003DE8 RID: 15848
		EPointerEventType_MAX
	}
}
