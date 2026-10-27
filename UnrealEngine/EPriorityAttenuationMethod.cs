using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B22 RID: 2850
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPriorityAttenuationMethod")]
	public enum EPriorityAttenuationMethod : byte
	{
		// Token: 0x04004E01 RID: 19969
		Linear,
		// Token: 0x04004E02 RID: 19970
		CustomCurve,
		// Token: 0x04004E03 RID: 19971
		Manual,
		// Token: 0x04004E04 RID: 19972
		EPriorityAttenuationMethod_MAX
	}
}
