using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA5 RID: 2725
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELightMegaLightsType")]
	public enum ELightMegaLightsType
	{
		// Token: 0x04004939 RID: 18745
		NoType,
		// Token: 0x0400493A RID: 18746
		OnlyMegaLights,
		// Token: 0x0400493B RID: 18747
		OnlyNotMegaLights,
		// Token: 0x0400493C RID: 18748
		ELightMegaLightsType_MAX
	}
}
