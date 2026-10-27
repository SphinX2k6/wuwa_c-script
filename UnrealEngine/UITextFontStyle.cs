using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021CD RID: 8653
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UITextFontStyle")]
	public enum UITextFontStyle : byte
	{
		// Token: 0x04011976 RID: 72054
		None,
		// Token: 0x04011977 RID: 72055
		Bold,
		// Token: 0x04011978 RID: 72056
		Italic,
		// Token: 0x04011979 RID: 72057
		BoldAndItalic,
		// Token: 0x0401197A RID: 72058
		UITextFontStyle_MAX
	}
}
