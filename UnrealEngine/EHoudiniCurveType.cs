using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001483 RID: 5251
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniCurveType")]
	public enum EHoudiniCurveType : sbyte
	{
		// Token: 0x0400A443 RID: 42051
		Invalid = -1,
		// Token: 0x0400A444 RID: 42052
		Polygon,
		// Token: 0x0400A445 RID: 42053
		Nurbs,
		// Token: 0x0400A446 RID: 42054
		Bezier,
		// Token: 0x0400A447 RID: 42055
		Points,
		// Token: 0x0400A448 RID: 42056
		EHoudiniCurveType_MAX
	}
}
