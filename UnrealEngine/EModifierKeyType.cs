using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001819 RID: 6169
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.EModifierKeyType")]
	public enum EModifierKeyType : byte
	{
		// Token: 0x0400C609 RID: 50697
		Control,
		// Token: 0x0400C60A RID: 50698
		LeftControl,
		// Token: 0x0400C60B RID: 50699
		RightControl,
		// Token: 0x0400C60C RID: 50700
		Shift,
		// Token: 0x0400C60D RID: 50701
		LeftShift,
		// Token: 0x0400C60E RID: 50702
		RightShift,
		// Token: 0x0400C60F RID: 50703
		Alt,
		// Token: 0x0400C610 RID: 50704
		LeftAlt,
		// Token: 0x0400C611 RID: 50705
		RightAlt,
		// Token: 0x0400C612 RID: 50706
		Command,
		// Token: 0x0400C613 RID: 50707
		LeftCommand,
		// Token: 0x0400C614 RID: 50708
		RightCommand,
		// Token: 0x0400C615 RID: 50709
		EModifierKeyType_MAX
	}
}
