using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012DC RID: 4828
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/FunctionalTesting.EFunctionalTestLogHandling")]
	public enum EFunctionalTestLogHandling : byte
	{
		// Token: 0x040097F6 RID: 38902
		ProjectDefault,
		// Token: 0x040097F7 RID: 38903
		OutputIsError,
		// Token: 0x040097F8 RID: 38904
		OutputIgnored,
		// Token: 0x040097F9 RID: 38905
		EFunctionalTestLogHandling_MAX
	}
}
