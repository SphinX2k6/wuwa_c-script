using System;

namespace UnrealEngine.Service
{
	// Token: 0x020008AC RID: 2220
	[Flags]
	public enum EConsoleVariableFlags : uint
	{
		// Token: 0x040056BF RID: 22207
		ECVF_FlagMask = 65535U,
		// Token: 0x040056C0 RID: 22208
		ECVF_Default = 0U,
		// Token: 0x040056C1 RID: 22209
		ECVF_Cheat = 1U,
		// Token: 0x040056C2 RID: 22210
		ECVF_ReadOnly = 4U,
		// Token: 0x040056C3 RID: 22211
		ECVF_Unregistered = 8U,
		// Token: 0x040056C4 RID: 22212
		ECVF_CreatedFromIni = 16U,
		// Token: 0x040056C5 RID: 22213
		ECVF_RenderThreadSafe = 32U,
		// Token: 0x040056C6 RID: 22214
		ECVF_Scalability = 64U,
		// Token: 0x040056C7 RID: 22215
		ECVF_ScalabilityGroup = 128U,
		// Token: 0x040056C8 RID: 22216
		ECVF_SetFlagMask = 16711680U,
		// Token: 0x040056C9 RID: 22217
		ECVF_Set_NoSinkCall_Unsafe = 65536U,
		// Token: 0x040056CA RID: 22218
		ECVF_SetByMask = 4278190080U,
		// Token: 0x040056CB RID: 22219
		ECVF_SetByConstructor = 0U,
		// Token: 0x040056CC RID: 22220
		ECVF_SetByScalability = 16777216U,
		// Token: 0x040056CD RID: 22221
		ECVF_SetByGameSetting = 33554432U,
		// Token: 0x040056CE RID: 22222
		ECVF_SetByProjectSetting = 50331648U,
		// Token: 0x040056CF RID: 22223
		ECVF_SetBySystemSettingsIni = 67108864U,
		// Token: 0x040056D0 RID: 22224
		ECVF_SetByDeviceProfile = 83886080U,
		// Token: 0x040056D1 RID: 22225
		ECVF_SetByConsoleVariablesIni = 100663296U,
		// Token: 0x040056D2 RID: 22226
		ECVF_SetByCommandline = 117440512U,
		// Token: 0x040056D3 RID: 22227
		ECVF_SetByCode = 134217728U,
		// Token: 0x040056D4 RID: 22228
		ECVF_SetByConsole = 150994944U
	}
}
