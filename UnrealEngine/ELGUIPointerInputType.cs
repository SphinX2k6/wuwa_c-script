using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200064E RID: 1614
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUIPointerInputType")]
	public enum ELGUIPointerInputType : byte
	{
		// Token: 0x04003DC0 RID: 15808
		Pointer,
		// Token: 0x04003DC1 RID: 15809
		Navigation,
		// Token: 0x04003DC2 RID: 15810
		None,
		// Token: 0x04003DC3 RID: 15811
		ELGUIPointerInputType_MAX
	}
}
