using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AE5 RID: 2789
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENavigationSystemInvokeMode")]
	public enum ENavigationSystemInvokeMode : byte
	{
		// Token: 0x04004B37 RID: 19255
		DefaultNavigationSystem,
		// Token: 0x04004B38 RID: 19256
		StreamingDungeon,
		// Token: 0x04004B39 RID: 19257
		ENavigationSystemInvokeMode_MAX
	}
}
