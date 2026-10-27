using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001479 RID: 5241
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineEditor.EHoudiniPublicAPIErrorLogOption")]
	public enum EHoudiniPublicAPIErrorLogOption : byte
	{
		// Token: 0x0400A3F3 RID: 41971
		Invalid,
		// Token: 0x0400A3F4 RID: 41972
		Auto,
		// Token: 0x0400A3F5 RID: 41973
		Log,
		// Token: 0x0400A3F6 RID: 41974
		NoLog,
		// Token: 0x0400A3F7 RID: 41975
		EHoudiniPublicAPIErrorLogOption_MAX
	}
}
