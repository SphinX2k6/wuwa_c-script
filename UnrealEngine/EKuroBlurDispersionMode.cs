using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024D6 RID: 9430
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.EKuroBlurDispersionMode")]
	public enum EKuroBlurDispersionMode : byte
	{
		// Token: 0x04012D67 RID: 77159
		RGBRadial,
		// Token: 0x04012D68 RID: 77160
		SpectralPrism,
		// Token: 0x04012D69 RID: 77161
		LensLateral,
		// Token: 0x04012D6A RID: 77162
		RadialDistance,
		// Token: 0x04012D6B RID: 77163
		EKuroBlurDispersionMode_MAX
	}
}
