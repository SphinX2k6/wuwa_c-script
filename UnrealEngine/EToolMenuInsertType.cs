using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002925 RID: 10533
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ToolMenus.EToolMenuInsertType")]
	public enum EToolMenuInsertType : byte
	{
		// Token: 0x040156AC RID: 87724
		Default,
		// Token: 0x040156AD RID: 87725
		Before,
		// Token: 0x040156AE RID: 87726
		After,
		// Token: 0x040156AF RID: 87727
		First,
		// Token: 0x040156B0 RID: 87728
		EToolMenuInsertType_MAX
	}
}
