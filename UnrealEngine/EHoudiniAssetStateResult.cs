using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200147F RID: 5247
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniAssetStateResult")]
	public enum EHoudiniAssetStateResult : byte
	{
		// Token: 0x0400A42B RID: 42027
		None,
		// Token: 0x0400A42C RID: 42028
		Working,
		// Token: 0x0400A42D RID: 42029
		Success,
		// Token: 0x0400A42E RID: 42030
		FinishedWithError,
		// Token: 0x0400A42F RID: 42031
		FinishedWithFatalError,
		// Token: 0x0400A430 RID: 42032
		Aborted,
		// Token: 0x0400A431 RID: 42033
		EHoudiniAssetStateResult_MAX
	}
}
