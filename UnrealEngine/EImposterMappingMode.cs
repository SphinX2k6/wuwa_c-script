using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200151E RID: 5406
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ImposterManager.EImposterMappingMode")]
	public enum EImposterMappingMode : byte
	{
		// Token: 0x0400AA06 RID: 43526
		FullSphere,
		// Token: 0x0400AA07 RID: 43527
		TiltedHemiOct,
		// Token: 0x0400AA08 RID: 43528
		EImposterMappingMode_MAX
	}
}
