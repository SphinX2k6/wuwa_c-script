using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E7 RID: 2535
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAlphaChannelMode")]
	public enum EAlphaChannelMode
	{
		// Token: 0x04004412 RID: 17426
		Disabled,
		// Token: 0x04004413 RID: 17427
		LinearColorSpaceOnly,
		// Token: 0x04004414 RID: 17428
		AllowThroughTonemapper,
		// Token: 0x04004415 RID: 17429
		EAlphaChannelMode_MAX
	}
}
