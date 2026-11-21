using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200064F RID: 1615
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EMouseButtonType")]
	public enum EMouseButtonType : byte
	{
		// Token: 0x04003DC5 RID: 15813
		Left,
		// Token: 0x04003DC6 RID: 15814
		Middle,
		// Token: 0x04003DC7 RID: 15815
		Right,
		// Token: 0x04003DC8 RID: 15816
		UserDefined1,
		// Token: 0x04003DC9 RID: 15817
		UserDefined2,
		// Token: 0x04003DCA RID: 15818
		UserDefined3,
		// Token: 0x04003DCB RID: 15819
		UserDefined4,
		// Token: 0x04003DCC RID: 15820
		UserDefined5,
		// Token: 0x04003DCD RID: 15821
		UserDefined6,
		// Token: 0x04003DCE RID: 15822
		UserDefined7,
		// Token: 0x04003DCF RID: 15823
		UserDefined8,
		// Token: 0x04003DD0 RID: 15824
		NavigationChange,
		// Token: 0x04003DD1 RID: 15825
		EMouseButtonType_MAX
	}
}
