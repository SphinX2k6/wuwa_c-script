using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200148C RID: 5260
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniLandscapeOutputBakeType")]
	public enum EHoudiniLandscapeOutputBakeType : byte
	{
		// Token: 0x0400A492 RID: 42130
		Detachment,
		// Token: 0x0400A493 RID: 42131
		BakeToImage,
		// Token: 0x0400A494 RID: 42132
		BakeToWorld,
		// Token: 0x0400A495 RID: 42133
		InValid,
		// Token: 0x0400A496 RID: 42134
		EHoudiniLandscapeOutputBakeType_MAX
	}
}
