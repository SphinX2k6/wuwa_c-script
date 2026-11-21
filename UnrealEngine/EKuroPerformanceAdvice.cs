using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000495 RID: 1173
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPerformance.EKuroPerformanceAdvice")]
	public enum EKuroPerformanceAdvice
	{
		// Token: 0x04002ED1 RID: 11985
		Pa_Error = -2,
		// Token: 0x04002ED2 RID: 11986
		Pa_None,
		// Token: 0x04002ED3 RID: 11987
		Pa_Free,
		// Token: 0x04002ED4 RID: 11988
		Pa_CBound,
		// Token: 0x04002ED5 RID: 11989
		Pa_GBound,
		// Token: 0x04002ED6 RID: 11990
		Pa_CGBound,
		// Token: 0x04002ED7 RID: 11991
		Pa_Downgrade,
		// Token: 0x04002ED8 RID: 11992
		Pa_Upgrade,
		// Token: 0x04002ED9 RID: 11993
		Pa_MAX
	}
}
