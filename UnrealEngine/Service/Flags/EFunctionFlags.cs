using System;

namespace UnrealEngine.Service.Flags
{
	// Token: 0x02002B08 RID: 11016
	[Flags]
	public enum EFunctionFlags : uint
	{
		// Token: 0x040162EF RID: 90863
		FUNC_None = 0U,
		// Token: 0x040162F0 RID: 90864
		FUNC_Final = 1U,
		// Token: 0x040162F1 RID: 90865
		FUNC_RequiredAPI = 2U,
		// Token: 0x040162F2 RID: 90866
		FUNC_BlueprintAuthorityOnly = 4U,
		// Token: 0x040162F3 RID: 90867
		FUNC_BlueprintCosmetic = 8U,
		// Token: 0x040162F4 RID: 90868
		FUNC_Net = 64U,
		// Token: 0x040162F5 RID: 90869
		FUNC_NetReliable = 128U,
		// Token: 0x040162F6 RID: 90870
		FUNC_NetRequest = 256U,
		// Token: 0x040162F7 RID: 90871
		FUNC_Exec = 512U,
		// Token: 0x040162F8 RID: 90872
		FUNC_Native = 1024U,
		// Token: 0x040162F9 RID: 90873
		FUNC_Event = 2048U,
		// Token: 0x040162FA RID: 90874
		FUNC_NetResponse = 4096U,
		// Token: 0x040162FB RID: 90875
		FUNC_Static = 8192U,
		// Token: 0x040162FC RID: 90876
		FUNC_NetMulticast = 16384U,
		// Token: 0x040162FD RID: 90877
		FUNC_UbergraphFunction = 32768U,
		// Token: 0x040162FE RID: 90878
		FUNC_MulticastDelegate = 65536U,
		// Token: 0x040162FF RID: 90879
		FUNC_Public = 131072U,
		// Token: 0x04016300 RID: 90880
		FUNC_Private = 262144U,
		// Token: 0x04016301 RID: 90881
		FUNC_Protected = 524288U,
		// Token: 0x04016302 RID: 90882
		FUNC_Delegate = 1048576U,
		// Token: 0x04016303 RID: 90883
		FUNC_NetServer = 2097152U,
		// Token: 0x04016304 RID: 90884
		FUNC_HasOutParms = 4194304U,
		// Token: 0x04016305 RID: 90885
		FUNC_HasDefaults = 8388608U,
		// Token: 0x04016306 RID: 90886
		FUNC_NetClient = 16777216U,
		// Token: 0x04016307 RID: 90887
		FUNC_DLLImport = 33554432U,
		// Token: 0x04016308 RID: 90888
		FUNC_BlueprintCallable = 67108864U,
		// Token: 0x04016309 RID: 90889
		FUNC_BlueprintEvent = 134217728U,
		// Token: 0x0401630A RID: 90890
		FUNC_BlueprintPure = 268435456U,
		// Token: 0x0401630B RID: 90891
		FUNC_EditorOnly = 536870912U,
		// Token: 0x0401630C RID: 90892
		FUNC_Const = 1073741824U,
		// Token: 0x0401630D RID: 90893
		FUNC_NetValidate = 2147483648U,
		// Token: 0x0401630E RID: 90894
		FUNC_BlueprintNativeEvent = 134220800U,
		// Token: 0x0401630F RID: 90895
		FUNC_BlueprintImplementableEvent = 134219776U,
		// Token: 0x04016310 RID: 90896
		FUNC_AllFlags = 4294967295U
	}
}
