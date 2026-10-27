using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A14 RID: 10772
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.ECSVImportType")]
	public enum ECSVImportType : byte
	{
		// Token: 0x04015D9A RID: 89498
		ECSV_DataTable,
		// Token: 0x04015D9B RID: 89499
		ECSV_CurveTable,
		// Token: 0x04015D9C RID: 89500
		ECSV_CurveFloat,
		// Token: 0x04015D9D RID: 89501
		ECSV_CurveVector,
		// Token: 0x04015D9E RID: 89502
		ECSV_CurveLinearColor,
		// Token: 0x04015D9F RID: 89503
		ECSV_MAX
	}
}
