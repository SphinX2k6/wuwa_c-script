using System;

namespace UnrealEngine.Service.Flags
{
	// Token: 0x020008B9 RID: 2233
	[Flags]
	public enum EPropertyFlags : ulong
	{
		// Token: 0x0400572A RID: 22314
		CPF_None = 0UL,
		// Token: 0x0400572B RID: 22315
		CPF_Edit = 1UL,
		// Token: 0x0400572C RID: 22316
		CPF_ConstParm = 2UL,
		// Token: 0x0400572D RID: 22317
		CPF_BlueprintVisible = 4UL,
		// Token: 0x0400572E RID: 22318
		CPF_ExportObject = 8UL,
		// Token: 0x0400572F RID: 22319
		CPF_BlueprintReadOnly = 16UL,
		// Token: 0x04005730 RID: 22320
		CPF_Net = 32UL,
		// Token: 0x04005731 RID: 22321
		CPF_EditFixedSize = 64UL,
		// Token: 0x04005732 RID: 22322
		CPF_Parm = 128UL,
		// Token: 0x04005733 RID: 22323
		CPF_OutParm = 256UL,
		// Token: 0x04005734 RID: 22324
		CPF_ZeroConstructor = 512UL,
		// Token: 0x04005735 RID: 22325
		CPF_ReturnParm = 1024UL,
		// Token: 0x04005736 RID: 22326
		CPF_DisableEditOnTemplate = 2048UL,
		// Token: 0x04005737 RID: 22327
		CPF_Transient = 8192UL,
		// Token: 0x04005738 RID: 22328
		CPF_Config = 16384UL,
		// Token: 0x04005739 RID: 22329
		CPF_DisableEditOnInstance = 65536UL,
		// Token: 0x0400573A RID: 22330
		CPF_EditConst = 131072UL,
		// Token: 0x0400573B RID: 22331
		CPF_GlobalConfig = 262144UL,
		// Token: 0x0400573C RID: 22332
		CPF_InstancedReference = 524288UL,
		// Token: 0x0400573D RID: 22333
		CPF_DuplicateTransient = 2097152UL,
		// Token: 0x0400573E RID: 22334
		CPF_SaveGame = 16777216UL,
		// Token: 0x0400573F RID: 22335
		CPF_NoClear = 33554432UL,
		// Token: 0x04005740 RID: 22336
		CPF_ReferenceParm = 134217728UL,
		// Token: 0x04005741 RID: 22337
		CPF_BlueprintAssignable = 268435456UL,
		// Token: 0x04005742 RID: 22338
		CPF_Deprecated = 536870912UL,
		// Token: 0x04005743 RID: 22339
		CPF_IsPlainOldData = 1073741824UL,
		// Token: 0x04005744 RID: 22340
		CPF_RepSkip = 2147483648UL,
		// Token: 0x04005745 RID: 22341
		CPF_RepNotify = 4294967296UL,
		// Token: 0x04005746 RID: 22342
		CPF_Interp = 8589934592UL,
		// Token: 0x04005747 RID: 22343
		CPF_NonTransactional = 17179869184UL,
		// Token: 0x04005748 RID: 22344
		CPF_EditorOnly = 34359738368UL,
		// Token: 0x04005749 RID: 22345
		CPF_NoDestructor = 68719476736UL,
		// Token: 0x0400574A RID: 22346
		CPF_AutoWeak = 274877906944UL,
		// Token: 0x0400574B RID: 22347
		CPF_ContainsInstancedReference = 549755813888UL,
		// Token: 0x0400574C RID: 22348
		CPF_AssetRegistrySearchable = 1099511627776UL,
		// Token: 0x0400574D RID: 22349
		CPF_SimpleDisplay = 2199023255552UL,
		// Token: 0x0400574E RID: 22350
		CPF_AdvancedDisplay = 4398046511104UL,
		// Token: 0x0400574F RID: 22351
		CPF_Protected = 8796093022208UL,
		// Token: 0x04005750 RID: 22352
		CPF_BlueprintCallable = 17592186044416UL,
		// Token: 0x04005751 RID: 22353
		CPF_BlueprintAuthorityOnly = 35184372088832UL,
		// Token: 0x04005752 RID: 22354
		CPF_TextExportTransient = 70368744177664UL,
		// Token: 0x04005753 RID: 22355
		CPF_NonPIEDuplicateTransient = 140737488355328UL,
		// Token: 0x04005754 RID: 22356
		CPF_ExposeOnSpawn = 281474976710656UL,
		// Token: 0x04005755 RID: 22357
		CPF_PersistentInstance = 562949953421312UL,
		// Token: 0x04005756 RID: 22358
		CPF_UObjectWrapper = 1125899906842624UL,
		// Token: 0x04005757 RID: 22359
		CPF_HasGetValueTypeHash = 2251799813685248UL,
		// Token: 0x04005758 RID: 22360
		CPF_NativeAccessSpecifierPublic = 4503599627370496UL,
		// Token: 0x04005759 RID: 22361
		CPF_NativeAccessSpecifierProtected = 9007199254740992UL,
		// Token: 0x0400575A RID: 22362
		CPF_NativeAccessSpecifierPrivate = 18014398509481984UL,
		// Token: 0x0400575B RID: 22363
		CPF_SkipSerialization = 36028797018963968UL
	}
}
