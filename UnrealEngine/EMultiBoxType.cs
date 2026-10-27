using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200284C RID: 10316
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EMultiBoxType")]
	public enum EMultiBoxType : byte
	{
		// Token: 0x04014FC5 RID: 85957
		MenuBar,
		// Token: 0x04014FC6 RID: 85958
		ToolBar,
		// Token: 0x04014FC7 RID: 85959
		VerticalToolBar,
		// Token: 0x04014FC8 RID: 85960
		UniformToolBar,
		// Token: 0x04014FC9 RID: 85961
		Menu,
		// Token: 0x04014FCA RID: 85962
		ButtonRow,
		// Token: 0x04014FCB RID: 85963
		EMultiBoxType_MAX
	}
}
