using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200043C RID: 1084
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ChaosCloth.EChaosClothTetherMode")]
	public enum EChaosClothTetherMode : byte
	{
		// Token: 0x04001AC2 RID: 6850
		FastTetherFastLength,
		// Token: 0x04001AC3 RID: 6851
		AccurateTetherFastLength,
		// Token: 0x04001AC4 RID: 6852
		AccurateTetherAccurateLength,
		// Token: 0x04001AC5 RID: 6853
		MaxChaosClothTetherMode,
		// Token: 0x04001AC6 RID: 6854
		EChaosClothTetherMode_MAX
	}
}
