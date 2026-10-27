using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001882 RID: 6274
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameplayUI.EDamageFormatType")]
	public enum EDamageFormatType : byte
	{
		// Token: 0x0400C8B1 RID: 51377
		Default,
		// Token: 0x0400C8B2 RID: 51378
		Pinball,
		// Token: 0x0400C8B3 RID: 51379
		DangoBrawl,
		// Token: 0x0400C8B4 RID: 51380
		EDamageFormatType_MAX
	}
}
