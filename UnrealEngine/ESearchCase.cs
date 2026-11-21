using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000106 RID: 262
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.ESearchCase")]
	public enum ESearchCase
	{
		// Token: 0x040004D1 RID: 1233
		CaseSensitive,
		// Token: 0x040004D2 RID: 1234
		IgnoreCase,
		// Token: 0x040004D3 RID: 1235
		ESearchCase_MAX
	}
}
