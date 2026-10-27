using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019D8 RID: 6616
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EClimbingArriveType")]
	public enum EClimbingArriveType
	{
		// Token: 0x0400D45D RID: 54365
		None,
		// Token: 0x0400D45E RID: 54366
		ClimbOnTop,
		// Token: 0x0400D45F RID: 54367
		ClimbVault,
		// Token: 0x0400D460 RID: 54368
		ClimbDownArrive,
		// Token: 0x0400D461 RID: 54369
		ClimbBlockUp,
		// Token: 0x0400D462 RID: 54370
		EClimbingArriveType_MAX
	}
}
