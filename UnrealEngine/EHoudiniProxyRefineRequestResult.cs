using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001493 RID: 5267
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniProxyRefineRequestResult")]
	public enum EHoudiniProxyRefineRequestResult : byte
	{
		// Token: 0x0400A4D0 RID: 42192
		Invalid,
		// Token: 0x0400A4D1 RID: 42193
		None,
		// Token: 0x0400A4D2 RID: 42194
		PendingCooks,
		// Token: 0x0400A4D3 RID: 42195
		Refined,
		// Token: 0x0400A4D4 RID: 42196
		EHoudiniProxyRefineRequestResult_MAX
	}
}
