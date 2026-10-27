using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001994 RID: 6548
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroInput.EInputMode")]
	public enum EInputMode : byte
	{
		// Token: 0x0400D286 RID: 53894
		GameOnly,
		// Token: 0x0400D287 RID: 53895
		GameAndUI,
		// Token: 0x0400D288 RID: 53896
		UIOnly,
		// Token: 0x0400D289 RID: 53897
		EInputMode_MAX
	}
}
