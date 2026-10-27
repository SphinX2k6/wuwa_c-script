using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C8F RID: 7311
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSDK.EPaymentType")]
	public enum EPaymentType : byte
	{
		// Token: 0x0400F3F4 RID: 62452
		Success = 1,
		// Token: 0x0400F3F5 RID: 62453
		Fail,
		// Token: 0x0400F3F6 RID: 62454
		Cancel,
		// Token: 0x0400F3F7 RID: 62455
		EPaymentType_MAX
	}
}
