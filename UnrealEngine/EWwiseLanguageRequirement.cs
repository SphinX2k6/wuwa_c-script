using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A70 RID: 10864
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WwiseFileHandler.EWwiseLanguageRequirement")]
	public enum EWwiseLanguageRequirement : byte
	{
		// Token: 0x04015FD6 RID: 90070
		IsDefault,
		// Token: 0x04015FD7 RID: 90071
		IsOptional,
		// Token: 0x04015FD8 RID: 90072
		SFX,
		// Token: 0x04015FD9 RID: 90073
		EWwiseLanguageRequirement_MAX
	}
}
