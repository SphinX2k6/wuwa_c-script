using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F2 RID: 2546
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAntiAliasingMethod")]
	public enum EAntiAliasingMethod
	{
		// Token: 0x0400444A RID: 17482
		AAM_None,
		// Token: 0x0400444B RID: 17483
		AAM_FXAA,
		// Token: 0x0400444C RID: 17484
		AAM_TemporalAA,
		// Token: 0x0400444D RID: 17485
		AAM_MSAA,
		// Token: 0x0400444E RID: 17486
		AAM_MAX
	}
}
