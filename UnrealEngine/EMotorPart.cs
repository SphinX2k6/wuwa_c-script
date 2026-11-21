using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200062B RID: 1579
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EMotorPart")]
	public enum EMotorPart : byte
	{
		// Token: 0x04003BC7 RID: 15303
		Body,
		// Token: 0x04003BC8 RID: 15304
		FrontWheel,
		// Token: 0x04003BC9 RID: 15305
		BackWheel,
		// Token: 0x04003BCA RID: 15306
		EMotorPart_MAX
	}
}
