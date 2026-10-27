using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000400 RID: 1024
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EPlaneComponentDebugMode")]
	public enum EPlaneComponentDebugMode : byte
	{
		// Token: 0x0400191A RID: 6426
		None,
		// Token: 0x0400191B RID: 6427
		ShowNetworkRole,
		// Token: 0x0400191C RID: 6428
		ShowClassification,
		// Token: 0x0400191D RID: 6429
		EPlaneComponentDebugMode_MAX
	}
}
