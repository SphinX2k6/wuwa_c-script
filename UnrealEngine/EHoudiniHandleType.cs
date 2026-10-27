using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001487 RID: 5255
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniHandleType")]
	public enum EHoudiniHandleType : byte
	{
		// Token: 0x0400A45E RID: 42078
		Xform,
		// Token: 0x0400A45F RID: 42079
		Bounder,
		// Token: 0x0400A460 RID: 42080
		Unsupported,
		// Token: 0x0400A461 RID: 42081
		EHoudiniHandleType_MAX
	}
}
