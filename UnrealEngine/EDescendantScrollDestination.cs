using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002847 RID: 10311
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EDescendantScrollDestination")]
	public enum EDescendantScrollDestination : byte
	{
		// Token: 0x04014FA2 RID: 85922
		IntoView,
		// Token: 0x04014FA3 RID: 85923
		TopOrLeft,
		// Token: 0x04014FA4 RID: 85924
		Center,
		// Token: 0x04014FA5 RID: 85925
		EDescendantScrollDestination_MAX
	}
}
