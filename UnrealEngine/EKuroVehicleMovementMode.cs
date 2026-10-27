using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F22 RID: 7970
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EKuroVehicleMovementMode")]
	public enum EKuroVehicleMovementMode
	{
		// Token: 0x04010505 RID: 66821
		KURO_VEHICLE_MOVE_None,
		// Token: 0x04010506 RID: 66822
		KURO_VEHICLE_MOVE_Falling,
		// Token: 0x04010507 RID: 66823
		KURO_VEHICLE_MOVE_Shipping,
		// Token: 0x04010508 RID: 66824
		KURO_VEHICLE_MOVE_Motorcycling,
		// Token: 0x04010509 RID: 66825
		KURO_VEHICLE_MOVE_Custom,
		// Token: 0x0401050A RID: 66826
		KURO_VEHICLE_MOVE_MAX
	}
}
