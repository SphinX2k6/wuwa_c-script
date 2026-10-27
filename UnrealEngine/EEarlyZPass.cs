using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A5D RID: 2653
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEarlyZPass")]
	public enum EEarlyZPass
	{
		// Token: 0x04004739 RID: 18233
		None,
		// Token: 0x0400473A RID: 18234
		OpaqueOnly,
		// Token: 0x0400473B RID: 18235
		OpaqueAndMasked,
		// Token: 0x0400473C RID: 18236
		Auto,
		// Token: 0x0400473D RID: 18237
		EEarlyZPass_MAX
	}
}
