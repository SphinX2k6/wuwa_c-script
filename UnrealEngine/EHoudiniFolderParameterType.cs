using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001486 RID: 5254
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniFolderParameterType")]
	public enum EHoudiniFolderParameterType : byte
	{
		// Token: 0x0400A456 RID: 42070
		Invalid,
		// Token: 0x0400A457 RID: 42071
		Collapsible,
		// Token: 0x0400A458 RID: 42072
		Simple,
		// Token: 0x0400A459 RID: 42073
		Tabs,
		// Token: 0x0400A45A RID: 42074
		Radio,
		// Token: 0x0400A45B RID: 42075
		Other,
		// Token: 0x0400A45C RID: 42076
		EHoudiniFolderParameterType_MAX
	}
}
