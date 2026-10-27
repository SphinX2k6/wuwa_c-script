using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200284B RID: 10315
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EMultiBlockType")]
	public enum EMultiBlockType : byte
	{
		// Token: 0x04014FBA RID: 85946
		None,
		// Token: 0x04014FBB RID: 85947
		ButtonRow,
		// Token: 0x04014FBC RID: 85948
		EditableText,
		// Token: 0x04014FBD RID: 85949
		Heading,
		// Token: 0x04014FBE RID: 85950
		MenuEntry,
		// Token: 0x04014FBF RID: 85951
		Separator,
		// Token: 0x04014FC0 RID: 85952
		ToolBarButton,
		// Token: 0x04014FC1 RID: 85953
		ToolBarComboButton,
		// Token: 0x04014FC2 RID: 85954
		Widget,
		// Token: 0x04014FC3 RID: 85955
		EMultiBlockType_MAX
	}
}
