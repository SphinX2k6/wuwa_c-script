using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AB0 RID: 2736
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialDomain")]
	public enum EMaterialDomain
	{
		// Token: 0x04004973 RID: 18803
		MD_Surface,
		// Token: 0x04004974 RID: 18804
		MD_DeferredDecal,
		// Token: 0x04004975 RID: 18805
		MD_LightFunction,
		// Token: 0x04004976 RID: 18806
		MD_Volume,
		// Token: 0x04004977 RID: 18807
		MD_PostProcess,
		// Token: 0x04004978 RID: 18808
		MD_UI,
		// Token: 0x04004979 RID: 18809
		MD_RuntimeVirtualTexture,
		// Token: 0x0400497A RID: 18810
		MD_MipMapDebug,
		// Token: 0x0400497B RID: 18811
		MD_MipMapBillDebug,
		// Token: 0x0400497C RID: 18812
		MD_MAX
	}
}
