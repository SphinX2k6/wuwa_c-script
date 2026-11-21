using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000858 RID: 2136
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.ESlateVisibility")]
	public enum ESlateVisibility : byte
	{
		// Token: 0x04005478 RID: 21624
		Visible,
		// Token: 0x04005479 RID: 21625
		Collapsed,
		// Token: 0x0400547A RID: 21626
		Hidden,
		// Token: 0x0400547B RID: 21627
		HitTestInvisible,
		// Token: 0x0400547C RID: 21628
		SelfHitTestInvisible,
		// Token: 0x0400547D RID: 21629
		ESlateVisibility_MAX
	}
}
