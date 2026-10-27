using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001491 RID: 5265
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniPCGSplineType")]
	public enum EHoudiniPCGSplineType : byte
	{
		// Token: 0x0400A4C7 RID: 42183
		Default,
		// Token: 0x0400A4C8 RID: 42184
		Water,
		// Token: 0x0400A4C9 RID: 42185
		Foliage,
		// Token: 0x0400A4CA RID: 42186
		EHoudiniPCGSplineType_MAX
	}
}
