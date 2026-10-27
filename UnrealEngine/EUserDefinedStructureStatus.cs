using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA8 RID: 2984
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EUserDefinedStructureStatus")]
	public enum EUserDefinedStructureStatus
	{
		// Token: 0x0400522A RID: 21034
		UDSS_UpToDate,
		// Token: 0x0400522B RID: 21035
		UDSS_Dirty,
		// Token: 0x0400522C RID: 21036
		UDSS_Error,
		// Token: 0x0400522D RID: 21037
		UDSS_Duplicate,
		// Token: 0x0400522E RID: 21038
		UDSS_MAX
	}
}
