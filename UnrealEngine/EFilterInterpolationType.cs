using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A6D RID: 2669
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFilterInterpolationType")]
	public enum EFilterInterpolationType
	{
		// Token: 0x0400479E RID: 18334
		BSIT_Average,
		// Token: 0x0400479F RID: 18335
		BSIT_Linear,
		// Token: 0x040047A0 RID: 18336
		BSIT_Cubic,
		// Token: 0x040047A1 RID: 18337
		BSIT_MAX
	}
}
