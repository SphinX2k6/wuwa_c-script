using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A0D RID: 2573
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBlendMode")]
	public enum EBlendMode
	{
		// Token: 0x040044E9 RID: 17641
		BLEND_Opaque,
		// Token: 0x040044EA RID: 17642
		BLEND_Masked,
		// Token: 0x040044EB RID: 17643
		BLEND_Translucent,
		// Token: 0x040044EC RID: 17644
		BLEND_Additive,
		// Token: 0x040044ED RID: 17645
		BLEND_Modulate,
		// Token: 0x040044EE RID: 17646
		BLEND_AlphaComposite,
		// Token: 0x040044EF RID: 17647
		BLEND_AlphaHoldout,
		// Token: 0x040044F0 RID: 17648
		BLEND_MAX
	}
}
