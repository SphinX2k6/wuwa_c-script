using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002926 RID: 10534
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ToolMenus.EToolMenuStringCommandType")]
	public enum EToolMenuStringCommandType : byte
	{
		// Token: 0x040156B2 RID: 87730
		Command,
		// Token: 0x040156B3 RID: 87731
		Python,
		// Token: 0x040156B4 RID: 87732
		Custom,
		// Token: 0x040156B5 RID: 87733
		EToolMenuStringCommandType_MAX
	}
}
