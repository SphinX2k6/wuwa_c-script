using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AAC RID: 2732
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELocationEmitterSelectionMethod")]
	public enum ELocationEmitterSelectionMethod
	{
		// Token: 0x0400495C RID: 18780
		ELESM_Random,
		// Token: 0x0400495D RID: 18781
		ELESM_Sequential,
		// Token: 0x0400495E RID: 18782
		ELESM_MAX
	}
}
