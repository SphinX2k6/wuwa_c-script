using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A32 RID: 2610
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECompositeTextureMode")]
	public enum ECompositeTextureMode
	{
		// Token: 0x040045DE RID: 17886
		CTM_Disabled,
		// Token: 0x040045DF RID: 17887
		CTM_NormalRoughnessToRed,
		// Token: 0x040045E0 RID: 17888
		CTM_NormalRoughnessToGreen,
		// Token: 0x040045E1 RID: 17889
		CTM_NormalRoughnessToBlue,
		// Token: 0x040045E2 RID: 17890
		CTM_NormalRoughnessToAlpha,
		// Token: 0x040045E3 RID: 17891
		CTM_ToonMaskToAlpha,
		// Token: 0x040045E4 RID: 17892
		CTM_MAX
	}
}
