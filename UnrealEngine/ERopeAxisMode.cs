using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C73 RID: 7283
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRopeEffect.ERopeAxisMode")]
	public enum ERopeAxisMode : byte
	{
		// Token: 0x0400F31D RID: 62237
		WorldUp,
		// Token: 0x0400F31E RID: 62238
		ActorUp,
		// Token: 0x0400F31F RID: 62239
		PrincipalAxis,
		// Token: 0x0400F320 RID: 62240
		ERopeAxisMode_MAX
	}
}
