using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000362 RID: 866
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroDataBag.EConfigApplyType")]
	public enum EConfigApplyType : byte
	{
		// Token: 0x0400248C RID: 9356
		Override,
		// Token: 0x0400248D RID: 9357
		Additive,
		// Token: 0x0400248E RID: 9358
		Multiply,
		// Token: 0x0400248F RID: 9359
		EConfigApplyType_MAX
	}
}
