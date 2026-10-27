using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001482 RID: 5250
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniCurveOutputType")]
	public enum EHoudiniCurveOutputType : byte
	{
		// Token: 0x0400A43F RID: 42047
		UnrealSpline,
		// Token: 0x0400A440 RID: 42048
		HoudiniSpline,
		// Token: 0x0400A441 RID: 42049
		EHoudiniCurveOutputType_MAX
	}
}
