using System;

namespace UnrealEngine.Service.Flags
{
	// Token: 0x02002B0A RID: 11018
	[Flags]
	public enum EStructFlags
	{
		// Token: 0x04016345 RID: 90949
		STRUCT_NoFlags = 0,
		// Token: 0x04016346 RID: 90950
		STRUCT_Native = 1,
		// Token: 0x04016347 RID: 90951
		STRUCT_IdenticalNative = 2,
		// Token: 0x04016348 RID: 90952
		STRUCT_HasInstancedReference = 4,
		// Token: 0x04016349 RID: 90953
		STRUCT_NoExport = 8,
		// Token: 0x0401634A RID: 90954
		STRUCT_Atomic = 16,
		// Token: 0x0401634B RID: 90955
		STRUCT_Immutable = 32,
		// Token: 0x0401634C RID: 90956
		STRUCT_AddStructReferencedObjects = 64,
		// Token: 0x0401634D RID: 90957
		STRUCT_RequiredAPI = 512,
		// Token: 0x0401634E RID: 90958
		STRUCT_NetSerializeNative = 1024,
		// Token: 0x0401634F RID: 90959
		STRUCT_SerializeNative = 2048,
		// Token: 0x04016350 RID: 90960
		STRUCT_CopyNative = 4096,
		// Token: 0x04016351 RID: 90961
		STRUCT_IsPlainOldData = 8192,
		// Token: 0x04016352 RID: 90962
		STRUCT_NoDestructor = 16384,
		// Token: 0x04016353 RID: 90963
		STRUCT_ZeroConstructor = 32768,
		// Token: 0x04016354 RID: 90964
		STRUCT_ExportTextItemNative = 65536,
		// Token: 0x04016355 RID: 90965
		STRUCT_ImportTextItemNative = 131072,
		// Token: 0x04016356 RID: 90966
		STRUCT_PostSerializeNative = 262144,
		// Token: 0x04016357 RID: 90967
		STRUCT_SerializeFromMismatchedTag = 524288,
		// Token: 0x04016358 RID: 90968
		STRUCT_NetDeltaSerializeNative = 1048576,
		// Token: 0x04016359 RID: 90969
		STRUCT_PostScriptConstruct = 2097152,
		// Token: 0x0401635A RID: 90970
		STRUCT_NetSharedSerialization = 4194304,
		// Token: 0x0401635B RID: 90971
		STRUCT_Trashed = 8388608,
		// Token: 0x0401635C RID: 90972
		STRUCT_Inherit = 20,
		// Token: 0x0401635D RID: 90973
		STRUCT_ComputedFlags = 8387650
	}
}
