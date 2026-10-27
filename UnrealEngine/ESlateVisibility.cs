using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200295A RID: 10586
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.ESlateVisibility")]
	public enum ESlateVisibility : byte
	{
		// Token: 0x0401589B RID: 88219
		Visible,
		// Token: 0x0401589C RID: 88220
		Collapsed,
		// Token: 0x0401589D RID: 88221
		Hidden,
		// Token: 0x0401589E RID: 88222
		HitTestInvisible,
		// Token: 0x0401589F RID: 88223
		SelfHitTestInvisible,
		// Token: 0x040158A0 RID: 88224
		ESlateVisibility_MAX
	}
}
