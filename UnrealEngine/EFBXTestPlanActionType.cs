using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A23 RID: 10787
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXTestPlanActionType")]
	public enum EFBXTestPlanActionType
	{
		// Token: 0x04015E0B RID: 89611
		Import,
		// Token: 0x04015E0C RID: 89612
		Reimport,
		// Token: 0x04015E0D RID: 89613
		AddLOD,
		// Token: 0x04015E0E RID: 89614
		ReimportLOD,
		// Token: 0x04015E0F RID: 89615
		ImportReload,
		// Token: 0x04015E10 RID: 89616
		EFBXTestPlanActionType_MAX
	}
}
