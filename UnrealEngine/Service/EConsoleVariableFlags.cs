using System;

namespace UnrealEngine.Service
{
	// Token: 0x02002AFC RID: 11004
	[Flags]
	public enum EConsoleVariableFlags : uint
	{
		// Token: 0x040162A7 RID: 90791
		ECVF_FlagMask = 65535U,
		// Token: 0x040162A8 RID: 90792
		ECVF_Default = 0U,
		// Token: 0x040162A9 RID: 90793
		ECVF_Cheat = 1U,
		// Token: 0x040162AA RID: 90794
		ECVF_ReadOnly = 4U,
		// Token: 0x040162AB RID: 90795
		ECVF_Unregistered = 8U,
		// Token: 0x040162AC RID: 90796
		ECVF_CreatedFromIni = 16U,
		// Token: 0x040162AD RID: 90797
		ECVF_RenderThreadSafe = 32U,
		// Token: 0x040162AE RID: 90798
		ECVF_Scalability = 64U,
		// Token: 0x040162AF RID: 90799
		ECVF_ScalabilityGroup = 128U,
		// Token: 0x040162B0 RID: 90800
		ECVF_SetFlagMask = 16711680U,
		// Token: 0x040162B1 RID: 90801
		ECVF_Set_NoSinkCall_Unsafe = 65536U,
		// Token: 0x040162B2 RID: 90802
		ECVF_SetByMask = 4278190080U,
		// Token: 0x040162B3 RID: 90803
		ECVF_SetByConstructor = 0U,
		// Token: 0x040162B4 RID: 90804
		ECVF_SetByScalability = 16777216U,
		// Token: 0x040162B5 RID: 90805
		ECVF_SetByGameSetting = 33554432U,
		// Token: 0x040162B6 RID: 90806
		ECVF_SetByProjectSetting = 50331648U,
		// Token: 0x040162B7 RID: 90807
		ECVF_SetBySystemSettingsIni = 67108864U,
		// Token: 0x040162B8 RID: 90808
		ECVF_SetByDeviceProfile = 83886080U,
		// Token: 0x040162B9 RID: 90809
		ECVF_SetByConsoleVariablesIni = 100663296U,
		// Token: 0x040162BA RID: 90810
		ECVF_SetByCommandline = 117440512U,
		// Token: 0x040162BB RID: 90811
		ECVF_SetByCode = 134217728U,
		// Token: 0x040162BC RID: 90812
		ECVF_SetByConsole = 150994944U
	}
}
