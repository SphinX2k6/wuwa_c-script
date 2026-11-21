using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000629 RID: 1577
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EFixFlyModeType")]
	public enum EFixFlyModeType : byte
	{
		// Token: 0x04003BBC RID: 15292
		FixHook,
		// Token: 0x04003BBD RID: 15293
		Catapult,
		// Token: 0x04003BBE RID: 15294
		EFixFlyModeType_MAX
	}
}
