using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200043E RID: 1086
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ChaosNiagara.EDataSortTypeEnum")]
	public enum EDataSortTypeEnum : byte
	{
		// Token: 0x04001AD3 RID: 6867
		ChaosNiagara_DataSortType_NoSorting,
		// Token: 0x04001AD4 RID: 6868
		ChaosNiagara_DataSortType_RandomShuffle,
		// Token: 0x04001AD5 RID: 6869
		ChaosNiagara_DataSortType_SortByMassMaxToMin,
		// Token: 0x04001AD6 RID: 6870
		ChaosNiagara_DataSortType_SortByMassMinToMax,
		// Token: 0x04001AD7 RID: 6871
		ChaosNiagara_Max,
		// Token: 0x04001AD8 RID: 6872
		ChaosNiagara_MAX
	}
}
