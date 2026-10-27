using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ABD RID: 2749
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialSamplerType")]
	public enum EMaterialSamplerType
	{
		// Token: 0x040049E9 RID: 18921
		SAMPLERTYPE_Color,
		// Token: 0x040049EA RID: 18922
		SAMPLERTYPE_Grayscale,
		// Token: 0x040049EB RID: 18923
		SAMPLERTYPE_Alpha,
		// Token: 0x040049EC RID: 18924
		SAMPLERTYPE_Normal,
		// Token: 0x040049ED RID: 18925
		SAMPLERTYPE_Masks,
		// Token: 0x040049EE RID: 18926
		SAMPLERTYPE_DistanceFieldFont,
		// Token: 0x040049EF RID: 18927
		SAMPLERTYPE_LinearColor,
		// Token: 0x040049F0 RID: 18928
		SAMPLERTYPE_LinearGrayscale,
		// Token: 0x040049F1 RID: 18929
		SAMPLERTYPE_Data,
		// Token: 0x040049F2 RID: 18930
		SAMPLERTYPE_External,
		// Token: 0x040049F3 RID: 18931
		SAMPLERTYPE_VirtualColor,
		// Token: 0x040049F4 RID: 18932
		SAMPLERTYPE_VirtualGrayscale,
		// Token: 0x040049F5 RID: 18933
		SAMPLERTYPE_VirtualAlpha,
		// Token: 0x040049F6 RID: 18934
		SAMPLERTYPE_VirtualNormal,
		// Token: 0x040049F7 RID: 18935
		SAMPLERTYPE_VirtualMasks,
		// Token: 0x040049F8 RID: 18936
		SAMPLERTYPE_VirtualLinearColor,
		// Token: 0x040049F9 RID: 18937
		SAMPLERTYPE_VirtualLinearGrayscale,
		// Token: 0x040049FA RID: 18938
		SAMPLERTYPE_MAX
	}
}
