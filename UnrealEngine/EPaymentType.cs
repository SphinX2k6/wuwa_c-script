using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000528 RID: 1320
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSDK.EPaymentType")]
	public enum EPaymentType : byte
	{
		// Token: 0x0400345E RID: 13406
		Success = 1,
		// Token: 0x0400345F RID: 13407
		Fail,
		// Token: 0x04003460 RID: 13408
		Cancel,
		// Token: 0x04003461 RID: 13409
		EPaymentType_MAX
	}
}
