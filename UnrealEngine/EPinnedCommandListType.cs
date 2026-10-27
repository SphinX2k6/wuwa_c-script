using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002649 RID: 9801
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PinnedCommandList.EPinnedCommandListType")]
	public enum EPinnedCommandListType : byte
	{
		// Token: 0x04013917 RID: 80151
		Command,
		// Token: 0x04013918 RID: 80152
		CustomWidget,
		// Token: 0x04013919 RID: 80153
		EPinnedCommandListType_MAX
	}
}
