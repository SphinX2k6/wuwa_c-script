using System;

namespace UnrealEngine.Service.Flags
{
	// Token: 0x02002B09 RID: 11017
	[Flags]
	public enum EPropertyFlags : ulong
	{
		// Token: 0x04016312 RID: 90898
		CPF_None = 0UL,
		// Token: 0x04016313 RID: 90899
		CPF_Edit = 1UL,
		// Token: 0x04016314 RID: 90900
		CPF_ConstParm = 2UL,
		// Token: 0x04016315 RID: 90901
		CPF_BlueprintVisible = 4UL,
		// Token: 0x04016316 RID: 90902
		CPF_ExportObject = 8UL,
		// Token: 0x04016317 RID: 90903
		CPF_BlueprintReadOnly = 16UL,
		// Token: 0x04016318 RID: 90904
		CPF_Net = 32UL,
		// Token: 0x04016319 RID: 90905
		CPF_EditFixedSize = 64UL,
		// Token: 0x0401631A RID: 90906
		CPF_Parm = 128UL,
		// Token: 0x0401631B RID: 90907
		CPF_OutParm = 256UL,
		// Token: 0x0401631C RID: 90908
		CPF_ZeroConstructor = 512UL,
		// Token: 0x0401631D RID: 90909
		CPF_ReturnParm = 1024UL,
		// Token: 0x0401631E RID: 90910
		CPF_DisableEditOnTemplate = 2048UL,
		// Token: 0x0401631F RID: 90911
		CPF_Transient = 8192UL,
		// Token: 0x04016320 RID: 90912
		CPF_Config = 16384UL,
		// Token: 0x04016321 RID: 90913
		CPF_DisableEditOnInstance = 65536UL,
		// Token: 0x04016322 RID: 90914
		CPF_EditConst = 131072UL,
		// Token: 0x04016323 RID: 90915
		CPF_GlobalConfig = 262144UL,
		// Token: 0x04016324 RID: 90916
		CPF_InstancedReference = 524288UL,
		// Token: 0x04016325 RID: 90917
		CPF_DuplicateTransient = 2097152UL,
		// Token: 0x04016326 RID: 90918
		CPF_SaveGame = 16777216UL,
		// Token: 0x04016327 RID: 90919
		CPF_NoClear = 33554432UL,
		// Token: 0x04016328 RID: 90920
		CPF_ReferenceParm = 134217728UL,
		// Token: 0x04016329 RID: 90921
		CPF_BlueprintAssignable = 268435456UL,
		// Token: 0x0401632A RID: 90922
		CPF_Deprecated = 536870912UL,
		// Token: 0x0401632B RID: 90923
		CPF_IsPlainOldData = 1073741824UL,
		// Token: 0x0401632C RID: 90924
		CPF_RepSkip = 2147483648UL,
		// Token: 0x0401632D RID: 90925
		CPF_RepNotify = 4294967296UL,
		// Token: 0x0401632E RID: 90926
		CPF_Interp = 8589934592UL,
		// Token: 0x0401632F RID: 90927
		CPF_NonTransactional = 17179869184UL,
		// Token: 0x04016330 RID: 90928
		CPF_EditorOnly = 34359738368UL,
		// Token: 0x04016331 RID: 90929
		CPF_NoDestructor = 68719476736UL,
		// Token: 0x04016332 RID: 90930
		CPF_AutoWeak = 274877906944UL,
		// Token: 0x04016333 RID: 90931
		CPF_ContainsInstancedReference = 549755813888UL,
		// Token: 0x04016334 RID: 90932
		CPF_AssetRegistrySearchable = 1099511627776UL,
		// Token: 0x04016335 RID: 90933
		CPF_SimpleDisplay = 2199023255552UL,
		// Token: 0x04016336 RID: 90934
		CPF_AdvancedDisplay = 4398046511104UL,
		// Token: 0x04016337 RID: 90935
		CPF_Protected = 8796093022208UL,
		// Token: 0x04016338 RID: 90936
		CPF_BlueprintCallable = 17592186044416UL,
		// Token: 0x04016339 RID: 90937
		CPF_BlueprintAuthorityOnly = 35184372088832UL,
		// Token: 0x0401633A RID: 90938
		CPF_TextExportTransient = 70368744177664UL,
		// Token: 0x0401633B RID: 90939
		CPF_NonPIEDuplicateTransient = 140737488355328UL,
		// Token: 0x0401633C RID: 90940
		CPF_ExposeOnSpawn = 281474976710656UL,
		// Token: 0x0401633D RID: 90941
		CPF_PersistentInstance = 562949953421312UL,
		// Token: 0x0401633E RID: 90942
		CPF_UObjectWrapper = 1125899906842624UL,
		// Token: 0x0401633F RID: 90943
		CPF_HasGetValueTypeHash = 2251799813685248UL,
		// Token: 0x04016340 RID: 90944
		CPF_NativeAccessSpecifierPublic = 4503599627370496UL,
		// Token: 0x04016341 RID: 90945
		CPF_NativeAccessSpecifierProtected = 9007199254740992UL,
		// Token: 0x04016342 RID: 90946
		CPF_NativeAccessSpecifierPrivate = 18014398509481984UL,
		// Token: 0x04016343 RID: 90947
		CPF_SkipSerialization = 36028797018963968UL
	}
}
