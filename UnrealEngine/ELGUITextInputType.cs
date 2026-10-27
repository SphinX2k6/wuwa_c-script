using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FE7 RID: 8167
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUITextInputType")]
	public enum ELGUITextInputType : byte
	{
		// Token: 0x04010B9B RID: 68507
		Standard,
		// Token: 0x04010B9C RID: 68508
		IntegerNumber,
		// Token: 0x04010B9D RID: 68509
		DecimalNumber,
		// Token: 0x04010B9E RID: 68510
		Password,
		// Token: 0x04010B9F RID: 68511
		CustomFunction,
		// Token: 0x04010BA0 RID: 68512
		ELGUITextInputType_MAX
	}
}
