using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A8E RID: 6798
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ESplineShareMode")]
	public enum ESplineShareMode : byte
	{
		// Token: 0x0400DA5E RID: 55902
		Independent,
		// Token: 0x0400DA5F RID: 55903
		SharedFirst,
		// Token: 0x0400DA60 RID: 55904
		SharedExternal,
		// Token: 0x0400DA61 RID: 55905
		ESplineShareMode_MAX
	}
}
