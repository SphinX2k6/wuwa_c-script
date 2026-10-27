using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001459 RID: 5209
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GSRTUModule.EGSRHistoryFormat")]
	public enum EGSRHistoryFormat
	{
		// Token: 0x0400A31C RID: 41756
		FloatRGBA,
		// Token: 0x0400A31D RID: 41757
		FloatR11G11B10,
		// Token: 0x0400A31E RID: 41758
		EGSRHistoryFormat_MAX
	}
}
