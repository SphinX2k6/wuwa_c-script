using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001485 RID: 5253
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniExecutableType")]
	public enum EHoudiniExecutableType
	{
		// Token: 0x0400A450 RID: 42064
		HRSHE_Houdini,
		// Token: 0x0400A451 RID: 42065
		HRSHE_HoudiniFX,
		// Token: 0x0400A452 RID: 42066
		HRSHE_HoudiniCore,
		// Token: 0x0400A453 RID: 42067
		HRSHE_HoudiniIndie,
		// Token: 0x0400A454 RID: 42068
		HRSHE_MAX
	}
}
