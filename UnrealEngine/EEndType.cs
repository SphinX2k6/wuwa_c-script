using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019C0 RID: 6592
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMath.EEndType")]
	public enum EEndType : byte
	{
		// Token: 0x0400D3EF RID: 54255
		Polygon,
		// Token: 0x0400D3F0 RID: 54256
		Joined,
		// Token: 0x0400D3F1 RID: 54257
		Butt,
		// Token: 0x0400D3F2 RID: 54258
		Square,
		// Token: 0x0400D3F3 RID: 54259
		Round,
		// Token: 0x0400D3F4 RID: 54260
		EEndType_MAX
	}
}
