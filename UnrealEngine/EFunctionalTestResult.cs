using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012DD RID: 4829
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/FunctionalTesting.EFunctionalTestResult")]
	public enum EFunctionalTestResult : byte
	{
		// Token: 0x040097FB RID: 38907
		Default,
		// Token: 0x040097FC RID: 38908
		Invalid,
		// Token: 0x040097FD RID: 38909
		Error,
		// Token: 0x040097FE RID: 38910
		Running,
		// Token: 0x040097FF RID: 38911
		Failed,
		// Token: 0x04009800 RID: 38912
		Succeeded,
		// Token: 0x04009801 RID: 38913
		EFunctionalTestResult_MAX
	}
}
