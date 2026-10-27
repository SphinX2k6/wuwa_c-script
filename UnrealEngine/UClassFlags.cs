using System;

namespace UnrealEngine
{
	// Token: 0x02002AD5 RID: 10965
	[Flags]
	public enum UClassFlags : uint
	{
		// Token: 0x0401618F RID: 90511
		CLASS_None = 0U,
		// Token: 0x04016190 RID: 90512
		CLASS_Abstract = 1U,
		// Token: 0x04016191 RID: 90513
		CLASS_DefaultConfig = 2U,
		// Token: 0x04016192 RID: 90514
		CLASS_Config = 4U,
		// Token: 0x04016193 RID: 90515
		CLASS_Transient = 8U,
		// Token: 0x04016194 RID: 90516
		CLASS_Parsed = 16U,
		// Token: 0x04016195 RID: 90517
		CLASS_MatchedSerializers = 32U,
		// Token: 0x04016196 RID: 90518
		CLASS_ProjectUserConfig = 64U,
		// Token: 0x04016197 RID: 90519
		CLASS_Native = 128U,
		// Token: 0x04016198 RID: 90520
		CLASS_NoExport = 256U,
		// Token: 0x04016199 RID: 90521
		CLASS_NotPlaceable = 512U,
		// Token: 0x0401619A RID: 90522
		CLASS_PerObjectConfig = 1024U,
		// Token: 0x0401619B RID: 90523
		CLASS_ReplicationDataIsSetUp = 2048U,
		// Token: 0x0401619C RID: 90524
		CLASS_EditInlineNew = 4096U,
		// Token: 0x0401619D RID: 90525
		CLASS_CollapseCategories = 8192U,
		// Token: 0x0401619E RID: 90526
		CLASS_Interface = 16384U,
		// Token: 0x0401619F RID: 90527
		CLASS_CustomConstructor = 32768U,
		// Token: 0x040161A0 RID: 90528
		CLASS_Const = 65536U,
		// Token: 0x040161A1 RID: 90529
		CLASS_LayoutChanging = 131072U,
		// Token: 0x040161A2 RID: 90530
		CLASS_CompiledFromBlueprint = 262144U,
		// Token: 0x040161A3 RID: 90531
		CLASS_MinimalAPI = 524288U,
		// Token: 0x040161A4 RID: 90532
		CLASS_RequiredAPI = 1048576U,
		// Token: 0x040161A5 RID: 90533
		CLASS_DefaultToInstanced = 2097152U,
		// Token: 0x040161A6 RID: 90534
		CLASS_TokenStreamAssembled = 4194304U,
		// Token: 0x040161A7 RID: 90535
		CLASS_HasInstancedReference = 8388608U,
		// Token: 0x040161A8 RID: 90536
		CLASS_Hidden = 16777216U,
		// Token: 0x040161A9 RID: 90537
		CLASS_Deprecated = 33554432U,
		// Token: 0x040161AA RID: 90538
		CLASS_HideDropDown = 67108864U,
		// Token: 0x040161AB RID: 90539
		CLASS_GlobalUserConfig = 134217728U,
		// Token: 0x040161AC RID: 90540
		CLASS_Intrinsic = 268435456U,
		// Token: 0x040161AD RID: 90541
		CLASS_Constructed = 536870912U,
		// Token: 0x040161AE RID: 90542
		CLASS_ConfigDoNotCheckDefaults = 1073741824U,
		// Token: 0x040161AF RID: 90543
		CLASS_NewerVersionExists = 2147483648U
	}
}
