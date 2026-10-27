using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F8 RID: 2552
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAttenuationDistanceModel")]
	public enum EAttenuationDistanceModel : byte
	{
		// Token: 0x0400446E RID: 17518
		Linear,
		// Token: 0x0400446F RID: 17519
		Logarithmic,
		// Token: 0x04004470 RID: 17520
		Inverse,
		// Token: 0x04004471 RID: 17521
		LogReverse,
		// Token: 0x04004472 RID: 17522
		NaturalSound,
		// Token: 0x04004473 RID: 17523
		Custom,
		// Token: 0x04004474 RID: 17524
		EAttenuationDistanceModel_MAX
	}
}
