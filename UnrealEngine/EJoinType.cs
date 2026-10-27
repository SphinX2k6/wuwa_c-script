using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019C1 RID: 6593
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMath.EJoinType")]
	public enum EJoinType : byte
	{
		// Token: 0x0400D3F6 RID: 54262
		Square,
		// Token: 0x0400D3F7 RID: 54263
		Round,
		// Token: 0x0400D3F8 RID: 54264
		Miter,
		// Token: 0x0400D3F9 RID: 54265
		EJoinType_MAX
	}
}
