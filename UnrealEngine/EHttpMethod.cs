using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019EF RID: 6639
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroNetwork.EHttpMethod")]
	public enum EHttpMethod : byte
	{
		// Token: 0x0400D4E9 RID: 54505
		GET,
		// Token: 0x0400D4EA RID: 54506
		POST,
		// Token: 0x0400D4EB RID: 54507
		EHttpMethod_MAX
	}
}
