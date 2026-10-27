using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002794 RID: 10132
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EOutputColorSpace")]
	public enum EOutputColorSpace : byte
	{
		// Token: 0x04014A09 RID: 84489
		Undefined,
		// Token: 0x04014A0A RID: 84490
		Linear,
		// Token: 0x04014A0B RID: 84491
		sRGB,
		// Token: 0x04014A0C RID: 84492
		EOutputColorSpace_MAX
	}
}
