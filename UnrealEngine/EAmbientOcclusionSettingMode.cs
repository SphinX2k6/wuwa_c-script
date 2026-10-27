using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200291A RID: 10522
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.EAmbientOcclusionSettingMode")]
	public enum EAmbientOcclusionSettingMode
	{
		// Token: 0x0401566D RID: 87661
		InheritFromLightmass,
		// Token: 0x0401566E RID: 87662
		DawnAOSetting,
		// Token: 0x0401566F RID: 87663
		EAmbientOcclusionSettingMode_MAX
	}
}
