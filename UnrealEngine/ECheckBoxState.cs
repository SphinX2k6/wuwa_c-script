using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027F8 RID: 10232
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.ECheckBoxState")]
	public enum ECheckBoxState : byte
	{
		// Token: 0x04014D58 RID: 85336
		Unchecked,
		// Token: 0x04014D59 RID: 85337
		Checked,
		// Token: 0x04014D5A RID: 85338
		Undetermined,
		// Token: 0x04014D5B RID: 85339
		ECheckBoxState_MAX
	}
}
