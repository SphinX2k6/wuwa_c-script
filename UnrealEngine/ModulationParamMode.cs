using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000EB3 RID: 3763
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ModulationParamMode")]
	public enum ModulationParamMode
	{
		// Token: 0x04006DBF RID: 28095
		MPM_Normal,
		// Token: 0x04006DC0 RID: 28096
		MPM_Abs,
		// Token: 0x04006DC1 RID: 28097
		MPM_Direct,
		// Token: 0x04006DC2 RID: 28098
		MPM_MAX
	}
}
