using System;

namespace UnrealEngine
{
	// Token: 0x02000079 RID: 121
	public enum EObjectFlags
	{
		// Token: 0x04000195 RID: 405
		RF_NoFlags,
		// Token: 0x04000196 RID: 406
		RF_Public,
		// Token: 0x04000197 RID: 407
		RF_Standalone,
		// Token: 0x04000198 RID: 408
		RF_MarkAsNative = 4,
		// Token: 0x04000199 RID: 409
		RF_Transactional = 8,
		// Token: 0x0400019A RID: 410
		RF_ClassDefaultObject = 16,
		// Token: 0x0400019B RID: 411
		RF_ArchetypeObject = 32,
		// Token: 0x0400019C RID: 412
		RF_Transient = 64,
		// Token: 0x0400019D RID: 413
		RF_MarkAsRootSet = 128,
		// Token: 0x0400019E RID: 414
		RF_TagGarbageTemp = 256,
		// Token: 0x0400019F RID: 415
		RF_NeedInitialization = 512,
		// Token: 0x040001A0 RID: 416
		RF_NeedLoad = 1024,
		// Token: 0x040001A1 RID: 417
		RF_KeepForCooker = 2048,
		// Token: 0x040001A2 RID: 418
		RF_NeedPostLoad = 4096,
		// Token: 0x040001A3 RID: 419
		RF_NeedPostLoadSubobjects = 8192,
		// Token: 0x040001A4 RID: 420
		RF_NewerVersionExists = 16384,
		// Token: 0x040001A5 RID: 421
		RF_BeginDestroyed = 32768,
		// Token: 0x040001A6 RID: 422
		RF_FinishDestroyed = 65536,
		// Token: 0x040001A7 RID: 423
		RF_BeingRegenerated = 131072,
		// Token: 0x040001A8 RID: 424
		RF_DefaultSubObject = 262144,
		// Token: 0x040001A9 RID: 425
		RF_WasLoaded = 524288,
		// Token: 0x040001AA RID: 426
		RF_TextExportTransient = 1048576,
		// Token: 0x040001AB RID: 427
		RF_LoadCompleted = 2097152,
		// Token: 0x040001AC RID: 428
		RF_InheritableComponentTemplate = 4194304,
		// Token: 0x040001AD RID: 429
		RF_DuplicateTransient = 8388608,
		// Token: 0x040001AE RID: 430
		RF_StrongRefOnFrame = 16777216,
		// Token: 0x040001AF RID: 431
		RF_NonPIEDuplicateTransient = 33554432,
		// Token: 0x040001B0 RID: 432
		RF_Dynamic = 67108864,
		// Token: 0x040001B1 RID: 433
		RF_WillBeLoaded = 134217728,
		// Token: 0x040001B2 RID: 434
		RF_HasExternalPackage = 268435456
	}
}
