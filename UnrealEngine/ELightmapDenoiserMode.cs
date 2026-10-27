using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002920 RID: 10528
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.ELightmapDenoiserMode")]
	public enum ELightmapDenoiserMode
	{
		// Token: 0x04015691 RID: 87697
		LightmapDenoiserMode_Optix,
		// Token: 0x04015692 RID: 87698
		LightmapDenoiserMode_Oidn,
		// Token: 0x04015693 RID: 87699
		LightmapDenoiserMode_None,
		// Token: 0x04015694 RID: 87700
		LightmapDenoiserMode_Max,
		// Token: 0x04015695 RID: 87701
		LightmapDenoiserMode_MAX
	}
}
