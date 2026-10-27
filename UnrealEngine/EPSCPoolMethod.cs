using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B25 RID: 2853
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSCPoolMethod")]
	public enum EPSCPoolMethod : byte
	{
		// Token: 0x04004E0F RID: 19983
		None,
		// Token: 0x04004E10 RID: 19984
		AutoRelease,
		// Token: 0x04004E11 RID: 19985
		ManualRelease,
		// Token: 0x04004E12 RID: 19986
		ManualRelease_OnComplete,
		// Token: 0x04004E13 RID: 19987
		FreeInPool,
		// Token: 0x04004E14 RID: 19988
		EPSCPoolMethod_MAX
	}
}
