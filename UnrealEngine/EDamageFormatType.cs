using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003AA RID: 938
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameplayUI.EDamageFormatType")]
	public enum EDamageFormatType : byte
	{
		// Token: 0x040026C0 RID: 9920
		Default,
		// Token: 0x040026C1 RID: 9921
		Pinball,
		// Token: 0x040026C2 RID: 9922
		DangoBrawl,
		// Token: 0x040026C3 RID: 9923
		EDamageFormatType_MAX
	}
}
