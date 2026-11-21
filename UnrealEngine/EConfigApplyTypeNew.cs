using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000363 RID: 867
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroDataBag.EConfigApplyTypeNew")]
	public enum EConfigApplyTypeNew : byte
	{
		// Token: 0x04002491 RID: 9361
		Override,
		// Token: 0x04002492 RID: 9362
		Additive,
		// Token: 0x04002493 RID: 9363
		Multiply,
		// Token: 0x04002494 RID: 9364
		EConfigApplyTypeNew_MAX
	}
}
