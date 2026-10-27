using System;

namespace UnrealEngine.Service.Flags
{
	// Token: 0x02002B06 RID: 11014
	[Flags]
	public enum EClassFlags : uint
	{
		// Token: 0x040162CA RID: 90826
		CLASS_None = 0U,
		// Token: 0x040162CB RID: 90827
		CLASS_Abstract = 1U,
		// Token: 0x040162CC RID: 90828
		CLASS_DefaultConfig = 2U,
		// Token: 0x040162CD RID: 90829
		CLASS_Config = 4U,
		// Token: 0x040162CE RID: 90830
		CLASS_Transient = 8U,
		// Token: 0x040162CF RID: 90831
		CLASS_Parsed = 16U,
		// Token: 0x040162D0 RID: 90832
		CLASS_MatchedSerializers = 32U,
		// Token: 0x040162D1 RID: 90833
		CLASS_ProjectUserConfig = 64U,
		// Token: 0x040162D2 RID: 90834
		CLASS_Native = 128U,
		// Token: 0x040162D3 RID: 90835
		CLASS_NoExport = 256U,
		// Token: 0x040162D4 RID: 90836
		CLASS_NotPlaceable = 512U,
		// Token: 0x040162D5 RID: 90837
		CLASS_PerObjectConfig = 1024U,
		// Token: 0x040162D6 RID: 90838
		CLASS_ReplicationDataIsSetUp = 2048U,
		// Token: 0x040162D7 RID: 90839
		CLASS_EditInlineNew = 4096U,
		// Token: 0x040162D8 RID: 90840
		CLASS_CollapseCategories = 8192U,
		// Token: 0x040162D9 RID: 90841
		CLASS_Interface = 16384U,
		// Token: 0x040162DA RID: 90842
		CLASS_CustomConstructor = 32768U,
		// Token: 0x040162DB RID: 90843
		CLASS_Const = 65536U,
		// Token: 0x040162DC RID: 90844
		CLASS_LayoutChanging = 131072U,
		// Token: 0x040162DD RID: 90845
		CLASS_CompiledFromBlueprint = 262144U,
		// Token: 0x040162DE RID: 90846
		CLASS_MinimalAPI = 524288U,
		// Token: 0x040162DF RID: 90847
		CLASS_RequiredAPI = 1048576U,
		// Token: 0x040162E0 RID: 90848
		CLASS_DefaultToInstanced = 2097152U,
		// Token: 0x040162E1 RID: 90849
		CLASS_TokenStreamAssembled = 4194304U,
		// Token: 0x040162E2 RID: 90850
		CLASS_HasInstancedReference = 8388608U,
		// Token: 0x040162E3 RID: 90851
		CLASS_Hidden = 16777216U,
		// Token: 0x040162E4 RID: 90852
		CLASS_Deprecated = 33554432U,
		// Token: 0x040162E5 RID: 90853
		CLASS_HideDropDown = 67108864U,
		// Token: 0x040162E6 RID: 90854
		CLASS_GlobalUserConfig = 134217728U,
		// Token: 0x040162E7 RID: 90855
		CLASS_Intrinsic = 268435456U,
		// Token: 0x040162E8 RID: 90856
		CLASS_Constructed = 536870912U,
		// Token: 0x040162E9 RID: 90857
		CLASS_ConfigDoNotCheckDefaults = 1073741824U,
		// Token: 0x040162EA RID: 90858
		CLASS_NewerVersionExists = 2147483648U
	}
}
