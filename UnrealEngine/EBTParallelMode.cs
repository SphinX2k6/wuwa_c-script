using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000177 RID: 375
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EBTParallelMode")]
	public enum EBTParallelMode
	{
		// Token: 0x04000678 RID: 1656
		AbortBackground,
		// Token: 0x04000679 RID: 1657
		WaitForBackground,
		// Token: 0x0400067A RID: 1658
		EBTParallelMode_MAX
	}
}
