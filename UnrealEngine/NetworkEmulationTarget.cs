using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A45 RID: 10821
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.NetworkEmulationTarget")]
	public enum NetworkEmulationTarget
	{
		// Token: 0x04015EDC RID: 89820
		Server,
		// Token: 0x04015EDD RID: 89821
		Client,
		// Token: 0x04015EDE RID: 89822
		Any,
		// Token: 0x04015EDF RID: 89823
		NetworkEmulationTarget_MAX
	}
}
