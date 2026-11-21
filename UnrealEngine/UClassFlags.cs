using System;

namespace UnrealEngine
{
	// Token: 0x02000884 RID: 2180
	[Flags]
	public enum UClassFlags : uint
	{
		// Token: 0x040055AA RID: 21930
		CLASS_None = 0U,
		// Token: 0x040055AB RID: 21931
		CLASS_Abstract = 1U,
		// Token: 0x040055AC RID: 21932
		CLASS_DefaultConfig = 2U,
		// Token: 0x040055AD RID: 21933
		CLASS_Config = 4U,
		// Token: 0x040055AE RID: 21934
		CLASS_Transient = 8U,
		// Token: 0x040055AF RID: 21935
		CLASS_Parsed = 16U,
		// Token: 0x040055B0 RID: 21936
		CLASS_MatchedSerializers = 32U,
		// Token: 0x040055B1 RID: 21937
		CLASS_ProjectUserConfig = 64U,
		// Token: 0x040055B2 RID: 21938
		CLASS_Native = 128U,
		// Token: 0x040055B3 RID: 21939
		CLASS_NoExport = 256U,
		// Token: 0x040055B4 RID: 21940
		CLASS_NotPlaceable = 512U,
		// Token: 0x040055B5 RID: 21941
		CLASS_PerObjectConfig = 1024U,
		// Token: 0x040055B6 RID: 21942
		CLASS_ReplicationDataIsSetUp = 2048U,
		// Token: 0x040055B7 RID: 21943
		CLASS_EditInlineNew = 4096U,
		// Token: 0x040055B8 RID: 21944
		CLASS_CollapseCategories = 8192U,
		// Token: 0x040055B9 RID: 21945
		CLASS_Interface = 16384U,
		// Token: 0x040055BA RID: 21946
		CLASS_CustomConstructor = 32768U,
		// Token: 0x040055BB RID: 21947
		CLASS_Const = 65536U,
		// Token: 0x040055BC RID: 21948
		CLASS_LayoutChanging = 131072U,
		// Token: 0x040055BD RID: 21949
		CLASS_CompiledFromBlueprint = 262144U,
		// Token: 0x040055BE RID: 21950
		CLASS_MinimalAPI = 524288U,
		// Token: 0x040055BF RID: 21951
		CLASS_RequiredAPI = 1048576U,
		// Token: 0x040055C0 RID: 21952
		CLASS_DefaultToInstanced = 2097152U,
		// Token: 0x040055C1 RID: 21953
		CLASS_TokenStreamAssembled = 4194304U,
		// Token: 0x040055C2 RID: 21954
		CLASS_HasInstancedReference = 8388608U,
		// Token: 0x040055C3 RID: 21955
		CLASS_Hidden = 16777216U,
		// Token: 0x040055C4 RID: 21956
		CLASS_Deprecated = 33554432U,
		// Token: 0x040055C5 RID: 21957
		CLASS_HideDropDown = 67108864U,
		// Token: 0x040055C6 RID: 21958
		CLASS_GlobalUserConfig = 134217728U,
		// Token: 0x040055C7 RID: 21959
		CLASS_Intrinsic = 268435456U,
		// Token: 0x040055C8 RID: 21960
		CLASS_Constructed = 536870912U,
		// Token: 0x040055C9 RID: 21961
		CLASS_ConfigDoNotCheckDefaults = 1073741824U,
		// Token: 0x040055CA RID: 21962
		CLASS_NewerVersionExists = 2147483648U
	}
}
