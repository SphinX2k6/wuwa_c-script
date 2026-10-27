using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000713 RID: 1811
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EDataValidationResult")]
	public enum EDataValidationResult : byte
	{
		// Token: 0x04002DC7 RID: 11719
		Invalid,
		// Token: 0x04002DC8 RID: 11720
		Valid,
		// Token: 0x04002DC9 RID: 11721
		NotValidated,
		// Token: 0x04002DCA RID: 11722
		EDataValidationResult_MAX
	}
}
