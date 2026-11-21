using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200062A RID: 1578
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EKuroVehicleMovementMode")]
	public enum EKuroVehicleMovementMode
	{
		// Token: 0x04003BC0 RID: 15296
		KURO_VEHICLE_MOVE_None,
		// Token: 0x04003BC1 RID: 15297
		KURO_VEHICLE_MOVE_Falling,
		// Token: 0x04003BC2 RID: 15298
		KURO_VEHICLE_MOVE_Shipping,
		// Token: 0x04003BC3 RID: 15299
		KURO_VEHICLE_MOVE_Motorcycling,
		// Token: 0x04003BC4 RID: 15300
		KURO_VEHICLE_MOVE_Custom,
		// Token: 0x04003BC5 RID: 15301
		KURO_VEHICLE_MOVE_MAX
	}
}
