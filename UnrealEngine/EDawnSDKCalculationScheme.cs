using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200077B RID: 1915
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/DawnSDKCommon.EDawnSDKCalculationScheme")]
	public enum EDawnSDKCalculationScheme
	{
		// Token: 0x04003025 RID: 12325
		ONLY_REMOTE,
		// Token: 0x04003026 RID: 12326
		MIX,
		// Token: 0x04003027 RID: 12327
		ONLY_LOCAL,
		// Token: 0x04003028 RID: 12328
		EDawnSDKCalculationScheme_MAX
	}
}
