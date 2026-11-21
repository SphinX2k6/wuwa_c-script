using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200062C RID: 1580
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EMotorSubState")]
	public enum EMotorSubState : byte
	{
		// Token: 0x04003BCC RID: 15308
		Stop,
		// Token: 0x04003BCD RID: 15309
		TwoWheelMoving,
		// Token: 0x04003BCE RID: 15310
		OneWheelMoving,
		// Token: 0x04003BCF RID: 15311
		AirMoving,
		// Token: 0x04003BD0 RID: 15312
		BrakingTurn,
		// Token: 0x04003BD1 RID: 15313
		Soaring,
		// Token: 0x04003BD2 RID: 15314
		EMotorSubState_MAX
	}
}
