using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002798 RID: 10136
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EOutputPixelFormat")]
	public enum EOutputPixelFormat : byte
	{
		// Token: 0x04014A22 RID: 84514
		R8G8B8A8,
		// Token: 0x04014A23 RID: 84515
		R8G8B8,
		// Token: 0x04014A24 RID: 84516
		R8,
		// Token: 0x04014A25 RID: 84517
		R16G16B16A16,
		// Token: 0x04014A26 RID: 84518
		R16G16B16,
		// Token: 0x04014A27 RID: 84519
		R16,
		// Token: 0x04014A28 RID: 84520
		R32G32B32A32F,
		// Token: 0x04014A29 RID: 84521
		EOutputPixelFormat_MAX
	}
}
