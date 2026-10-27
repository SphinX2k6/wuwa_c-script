using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001499 RID: 5273
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniXformType")]
	public enum EHoudiniXformType : byte
	{
		// Token: 0x0400A4F6 RID: 42230
		None,
		// Token: 0x0400A4F7 RID: 42231
		IntoThisObject,
		// Token: 0x0400A4F8 RID: 42232
		Auto,
		// Token: 0x0400A4F9 RID: 42233
		EHoudiniXformType_MAX
	}
}
