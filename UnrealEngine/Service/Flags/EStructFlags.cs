using System;

namespace UnrealEngine.Service.Flags
{
	// Token: 0x020008BA RID: 2234
	[Flags]
	public enum EStructFlags
	{
		// Token: 0x0400575D RID: 22365
		STRUCT_NoFlags = 0,
		// Token: 0x0400575E RID: 22366
		STRUCT_Native = 1,
		// Token: 0x0400575F RID: 22367
		STRUCT_IdenticalNative = 2,
		// Token: 0x04005760 RID: 22368
		STRUCT_HasInstancedReference = 4,
		// Token: 0x04005761 RID: 22369
		STRUCT_NoExport = 8,
		// Token: 0x04005762 RID: 22370
		STRUCT_Atomic = 16,
		// Token: 0x04005763 RID: 22371
		STRUCT_Immutable = 32,
		// Token: 0x04005764 RID: 22372
		STRUCT_AddStructReferencedObjects = 64,
		// Token: 0x04005765 RID: 22373
		STRUCT_RequiredAPI = 512,
		// Token: 0x04005766 RID: 22374
		STRUCT_NetSerializeNative = 1024,
		// Token: 0x04005767 RID: 22375
		STRUCT_SerializeNative = 2048,
		// Token: 0x04005768 RID: 22376
		STRUCT_CopyNative = 4096,
		// Token: 0x04005769 RID: 22377
		STRUCT_IsPlainOldData = 8192,
		// Token: 0x0400576A RID: 22378
		STRUCT_NoDestructor = 16384,
		// Token: 0x0400576B RID: 22379
		STRUCT_ZeroConstructor = 32768,
		// Token: 0x0400576C RID: 22380
		STRUCT_ExportTextItemNative = 65536,
		// Token: 0x0400576D RID: 22381
		STRUCT_ImportTextItemNative = 131072,
		// Token: 0x0400576E RID: 22382
		STRUCT_PostSerializeNative = 262144,
		// Token: 0x0400576F RID: 22383
		STRUCT_SerializeFromMismatchedTag = 524288,
		// Token: 0x04005770 RID: 22384
		STRUCT_NetDeltaSerializeNative = 1048576,
		// Token: 0x04005771 RID: 22385
		STRUCT_PostScriptConstruct = 2097152,
		// Token: 0x04005772 RID: 22386
		STRUCT_NetSharedSerialization = 4194304,
		// Token: 0x04005773 RID: 22387
		STRUCT_Trashed = 8388608,
		// Token: 0x04005774 RID: 22388
		STRUCT_Inherit = 20,
		// Token: 0x04005775 RID: 22389
		STRUCT_ComputedFlags = 8387650
	}
}
