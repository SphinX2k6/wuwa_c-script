using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001530 RID: 5424
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/InstanceTool.ESelectAllOption")]
	public enum ESelectAllOption : byte
	{
		// Token: 0x0400AA83 RID: 43651
		SameActorAsSelected,
		// Token: 0x0400AA84 RID: 43652
		SameComponentAsSelected,
		// Token: 0x0400AA85 RID: 43653
		ESelectAllOption_MAX
	}
}
