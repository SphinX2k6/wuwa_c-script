using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002E4 RID: 740
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ECharPositionStateType")]
	public enum ECharPositionStateType : byte
	{
		// Token: 0x04002037 RID: 8247
		Ground,
		// Token: 0x04002038 RID: 8248
		Climb,
		// Token: 0x04002039 RID: 8249
		Air,
		// Token: 0x0400203A RID: 8250
		Water,
		// Token: 0x0400203B RID: 8251
		Ski,
		// Token: 0x0400203C RID: 8252
		Ride,
		// Token: 0x0400203D RID: 8253
		RailSlide,
		// Token: 0x0400203E RID: 8254
		Floating,
		// Token: 0x0400203F RID: 8255
		MechAllTerrain,
		// Token: 0x04002040 RID: 8256
		FlowerAllTerrain,
		// Token: 0x04002041 RID: 8257
		ECharPositionStateType_MAX
	}
}
