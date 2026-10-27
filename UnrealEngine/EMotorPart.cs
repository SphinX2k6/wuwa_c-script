using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F23 RID: 7971
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EMotorPart")]
	public enum EMotorPart : byte
	{
		// Token: 0x0401050C RID: 66828
		Body,
		// Token: 0x0401050D RID: 66829
		FrontWheel,
		// Token: 0x0401050E RID: 66830
		BackWheel,
		// Token: 0x0401050F RID: 66831
		EMotorPart_MAX
	}
}
