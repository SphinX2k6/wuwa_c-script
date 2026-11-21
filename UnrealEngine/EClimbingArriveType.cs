using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000466 RID: 1126
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EClimbingArriveType")]
	public enum EClimbingArriveType
	{
		// Token: 0x04002DCF RID: 11727
		None,
		// Token: 0x04002DD0 RID: 11728
		ClimbOnTop,
		// Token: 0x04002DD1 RID: 11729
		ClimbVault,
		// Token: 0x04002DD2 RID: 11730
		ClimbDownArrive,
		// Token: 0x04002DD3 RID: 11731
		ClimbBlockUp,
		// Token: 0x04002DD4 RID: 11732
		EClimbingArriveType_MAX
	}
}
