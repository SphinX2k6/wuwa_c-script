using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001826 RID: 6182
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEffectMakerEditor.EKuroEffectMakerMeshBuilderAttributeBlendMode")]
	public enum EKuroEffectMakerMeshBuilderAttributeBlendMode : byte
	{
		// Token: 0x0400C660 RID: 50784
		Replace,
		// Token: 0x0400C661 RID: 50785
		Add,
		// Token: 0x0400C662 RID: 50786
		Multiply,
		// Token: 0x0400C663 RID: 50787
		Subtract,
		// Token: 0x0400C664 RID: 50788
		Max,
		// Token: 0x0400C665 RID: 50789
		Min,
		// Token: 0x0400C666 RID: 50790
		EKuroEffectMakerMeshBuilderAttributeBlendMode_MAX
	}
}
