using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002759 RID: 10073
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sharphereal.EKooSharpMonoTraceLevel")]
	public enum EKooSharpMonoTraceLevel : byte
	{
		// Token: 0x040147D3 RID: 83923
		error,
		// Token: 0x040147D4 RID: 83924
		critical,
		// Token: 0x040147D5 RID: 83925
		warning,
		// Token: 0x040147D6 RID: 83926
		message,
		// Token: 0x040147D7 RID: 83927
		info,
		// Token: 0x040147D8 RID: 83928
		debug,
		// Token: 0x040147D9 RID: 83929
		EKooSharpMonoTraceLevel_MAX
	}
}
