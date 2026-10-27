using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000CA RID: 202
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ACLPlugin.ACLVisualFidelity")]
	public enum ACLVisualFidelity : byte
	{
		// Token: 0x04000282 RID: 642
		Highest,
		// Token: 0x04000283 RID: 643
		Medium,
		// Token: 0x04000284 RID: 644
		Lowest,
		// Token: 0x04000285 RID: 645
		ACLVisualFidelity_MAX
	}
}
