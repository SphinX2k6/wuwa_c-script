using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200174D RID: 5965
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.EAnimPerfTestAnimSeqFilterMethod")]
	public enum EAnimPerfTestAnimSeqFilterMethod : sbyte
	{
		// Token: 0x0400BB2A RID: 47914
		Specific,
		// Token: 0x0400BB2B RID: 47915
		Contains,
		// Token: 0x0400BB2C RID: 47916
		StartsWith,
		// Token: 0x0400BB2D RID: 47917
		EndsWith,
		// Token: 0x0400BB2E RID: 47918
		EqualsTo,
		// Token: 0x0400BB2F RID: 47919
		EAnimPerfTestAnimSeqFilterMethod_MAX
	}
}
