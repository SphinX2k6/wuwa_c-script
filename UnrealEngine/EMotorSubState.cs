using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F24 RID: 7972
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EMotorSubState")]
	public enum EMotorSubState : byte
	{
		// Token: 0x04010511 RID: 66833
		Stop,
		// Token: 0x04010512 RID: 66834
		TwoWheelMoving,
		// Token: 0x04010513 RID: 66835
		OneWheelMoving,
		// Token: 0x04010514 RID: 66836
		AirMoving,
		// Token: 0x04010515 RID: 66837
		BrakingTurn,
		// Token: 0x04010516 RID: 66838
		Soaring,
		// Token: 0x04010517 RID: 66839
		EMotorSubState_MAX
	}
}
