using System;

namespace UnrealEngine
{
	// Token: 0x0200005E RID: 94
	public enum EObjectFlags
	{
		// Token: 0x0400014E RID: 334
		RF_NoFlags,
		// Token: 0x0400014F RID: 335
		RF_Public,
		// Token: 0x04000150 RID: 336
		RF_Standalone,
		// Token: 0x04000151 RID: 337
		RF_MarkAsNative = 4,
		// Token: 0x04000152 RID: 338
		RF_Transactional = 8,
		// Token: 0x04000153 RID: 339
		RF_ClassDefaultObject = 16,
		// Token: 0x04000154 RID: 340
		RF_ArchetypeObject = 32,
		// Token: 0x04000155 RID: 341
		RF_Transient = 64,
		// Token: 0x04000156 RID: 342
		RF_MarkAsRootSet = 128,
		// Token: 0x04000157 RID: 343
		RF_TagGarbageTemp = 256,
		// Token: 0x04000158 RID: 344
		RF_NeedInitialization = 512,
		// Token: 0x04000159 RID: 345
		RF_NeedLoad = 1024,
		// Token: 0x0400015A RID: 346
		RF_KeepForCooker = 2048,
		// Token: 0x0400015B RID: 347
		RF_NeedPostLoad = 4096,
		// Token: 0x0400015C RID: 348
		RF_NeedPostLoadSubobjects = 8192,
		// Token: 0x0400015D RID: 349
		RF_NewerVersionExists = 16384,
		// Token: 0x0400015E RID: 350
		RF_BeginDestroyed = 32768,
		// Token: 0x0400015F RID: 351
		RF_FinishDestroyed = 65536,
		// Token: 0x04000160 RID: 352
		RF_BeingRegenerated = 131072,
		// Token: 0x04000161 RID: 353
		RF_DefaultSubObject = 262144,
		// Token: 0x04000162 RID: 354
		RF_WasLoaded = 524288,
		// Token: 0x04000163 RID: 355
		RF_TextExportTransient = 1048576,
		// Token: 0x04000164 RID: 356
		RF_LoadCompleted = 2097152,
		// Token: 0x04000165 RID: 357
		RF_InheritableComponentTemplate = 4194304,
		// Token: 0x04000166 RID: 358
		RF_DuplicateTransient = 8388608,
		// Token: 0x04000167 RID: 359
		RF_StrongRefOnFrame = 16777216,
		// Token: 0x04000168 RID: 360
		RF_NonPIEDuplicateTransient = 33554432,
		// Token: 0x04000169 RID: 361
		RF_Dynamic = 67108864,
		// Token: 0x0400016A RID: 362
		RF_WillBeLoaded = 134217728,
		// Token: 0x0400016B RID: 363
		RF_HasExternalPackage = 268435456
	}
}
