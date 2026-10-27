using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001477 RID: 5239
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineEditor.EHoudiniPublicAPICurveMethod")]
	public enum EHoudiniPublicAPICurveMethod : byte
	{
		// Token: 0x0400A3E6 RID: 41958
		Invalid,
		// Token: 0x0400A3E7 RID: 41959
		CVs,
		// Token: 0x0400A3E8 RID: 41960
		Breakpoints,
		// Token: 0x0400A3E9 RID: 41961
		Freehand,
		// Token: 0x0400A3EA RID: 41962
		EHoudiniPublicAPICurveMethod_MAX
	}
}
