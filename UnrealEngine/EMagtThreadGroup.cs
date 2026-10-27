using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002261 RID: 8801
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MagtModule.EMagtThreadGroup")]
	public enum EMagtThreadGroup : byte
	{
		// Token: 0x04011D95 RID: 73109
		Default,
		// Token: 0x04011D96 RID: 73110
		Critical,
		// Token: 0x04011D97 RID: 73111
		Audio,
		// Token: 0x04011D98 RID: 73112
		EMagtThreadGroup_MAX
	}
}
