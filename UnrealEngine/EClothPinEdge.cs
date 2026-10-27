using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001776 RID: 6006
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EClothPinEdge")]
	public enum EClothPinEdge : byte
	{
		// Token: 0x0400BCBD RID: 48317
		Top,
		// Token: 0x0400BCBE RID: 48318
		Bottom,
		// Token: 0x0400BCBF RID: 48319
		Left,
		// Token: 0x0400BCC0 RID: 48320
		Right,
		// Token: 0x0400BCC1 RID: 48321
		EClothPinEdge_MAX
	}
}
