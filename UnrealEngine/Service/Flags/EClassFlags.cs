using System;

namespace UnrealEngine.Service.Flags
{
	// Token: 0x020008B6 RID: 2230
	[Flags]
	public enum EClassFlags : uint
	{
		// Token: 0x040056E2 RID: 22242
		CLASS_None = 0U,
		// Token: 0x040056E3 RID: 22243
		CLASS_Abstract = 1U,
		// Token: 0x040056E4 RID: 22244
		CLASS_DefaultConfig = 2U,
		// Token: 0x040056E5 RID: 22245
		CLASS_Config = 4U,
		// Token: 0x040056E6 RID: 22246
		CLASS_Transient = 8U,
		// Token: 0x040056E7 RID: 22247
		CLASS_Parsed = 16U,
		// Token: 0x040056E8 RID: 22248
		CLASS_MatchedSerializers = 32U,
		// Token: 0x040056E9 RID: 22249
		CLASS_ProjectUserConfig = 64U,
		// Token: 0x040056EA RID: 22250
		CLASS_Native = 128U,
		// Token: 0x040056EB RID: 22251
		CLASS_NoExport = 256U,
		// Token: 0x040056EC RID: 22252
		CLASS_NotPlaceable = 512U,
		// Token: 0x040056ED RID: 22253
		CLASS_PerObjectConfig = 1024U,
		// Token: 0x040056EE RID: 22254
		CLASS_ReplicationDataIsSetUp = 2048U,
		// Token: 0x040056EF RID: 22255
		CLASS_EditInlineNew = 4096U,
		// Token: 0x040056F0 RID: 22256
		CLASS_CollapseCategories = 8192U,
		// Token: 0x040056F1 RID: 22257
		CLASS_Interface = 16384U,
		// Token: 0x040056F2 RID: 22258
		CLASS_CustomConstructor = 32768U,
		// Token: 0x040056F3 RID: 22259
		CLASS_Const = 65536U,
		// Token: 0x040056F4 RID: 22260
		CLASS_LayoutChanging = 131072U,
		// Token: 0x040056F5 RID: 22261
		CLASS_CompiledFromBlueprint = 262144U,
		// Token: 0x040056F6 RID: 22262
		CLASS_MinimalAPI = 524288U,
		// Token: 0x040056F7 RID: 22263
		CLASS_RequiredAPI = 1048576U,
		// Token: 0x040056F8 RID: 22264
		CLASS_DefaultToInstanced = 2097152U,
		// Token: 0x040056F9 RID: 22265
		CLASS_TokenStreamAssembled = 4194304U,
		// Token: 0x040056FA RID: 22266
		CLASS_HasInstancedReference = 8388608U,
		// Token: 0x040056FB RID: 22267
		CLASS_Hidden = 16777216U,
		// Token: 0x040056FC RID: 22268
		CLASS_Deprecated = 33554432U,
		// Token: 0x040056FD RID: 22269
		CLASS_HideDropDown = 67108864U,
		// Token: 0x040056FE RID: 22270
		CLASS_GlobalUserConfig = 134217728U,
		// Token: 0x040056FF RID: 22271
		CLASS_Intrinsic = 268435456U,
		// Token: 0x04005700 RID: 22272
		CLASS_Constructed = 536870912U,
		// Token: 0x04005701 RID: 22273
		CLASS_ConfigDoNotCheckDefaults = 1073741824U,
		// Token: 0x04005702 RID: 22274
		CLASS_NewerVersionExists = 2147483648U
	}
}
