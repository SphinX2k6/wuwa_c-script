using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200064D RID: 1613
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUINavigationDirection")]
	public enum ELGUINavigationDirection : byte
	{
		// Token: 0x04003DB7 RID: 15799
		None,
		// Token: 0x04003DB8 RID: 15800
		Left,
		// Token: 0x04003DB9 RID: 15801
		Right,
		// Token: 0x04003DBA RID: 15802
		Up,
		// Token: 0x04003DBB RID: 15803
		Down,
		// Token: 0x04003DBC RID: 15804
		Next,
		// Token: 0x04003DBD RID: 15805
		Prev,
		// Token: 0x04003DBE RID: 15806
		ELGUINavigationDirection_MAX
	}
}
