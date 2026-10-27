using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200152A RID: 5418
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/InstanceTool.EAlignSnapCoord")]
	public enum EAlignSnapCoord : byte
	{
		// Token: 0x0400AA61 RID: 43617
		Auto,
		// Token: 0x0400AA62 RID: 43618
		Local,
		// Token: 0x0400AA63 RID: 43619
		World,
		// Token: 0x0400AA64 RID: 43620
		EAlignSnapCoord_MAX
	}
}
