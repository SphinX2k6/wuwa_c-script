using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A9 RID: 1193
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroCharSlotSpecifiedType")]
	public enum EKuroCharSlotSpecifiedType : byte
	{
		// Token: 0x04002FB0 RID: 12208
		All,
		// Token: 0x04002FB1 RID: 12209
		BodyAndOutline,
		// Token: 0x04002FB2 RID: 12210
		Body,
		// Token: 0x04002FB3 RID: 12211
		Outline,
		// Token: 0x04002FB4 RID: 12212
		ECharacterSlotSpecifiedType_Max,
		// Token: 0x04002FB5 RID: 12213
		EKuroCharSlotSpecifiedType_MAX
	}
}
