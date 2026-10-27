using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A6D RID: 6765
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ECustomRuntimeGrid")]
	public enum ECustomRuntimeGrid : byte
	{
		// Token: 0x0400D8D9 RID: 55513
		Grid_Near,
		// Token: 0x0400D8DA RID: 55514
		Grid_Middle,
		// Token: 0x0400D8DB RID: 55515
		Grid_Far,
		// Token: 0x0400D8DC RID: 55516
		Grid_SuperFar,
		// Token: 0x0400D8DD RID: 55517
		Grid_MAX
	}
}
