using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002E6 RID: 742
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EClimbStateType")]
	public enum EClimbStateType : byte
	{
		// Token: 0x0400204A RID: 8266
		None,
		// Token: 0x0400204B RID: 8267
		EnterClimb,
		// Token: 0x0400204C RID: 8268
		Climbing,
		// Token: 0x0400204D RID: 8269
		ExitClimb,
		// Token: 0x0400204E RID: 8270
		EClimbStateType_MAX
	}
}
