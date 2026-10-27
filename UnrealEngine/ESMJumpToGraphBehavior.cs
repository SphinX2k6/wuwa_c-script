using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002863 RID: 10339
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystemEditor.ESMJumpToGraphBehavior")]
	public enum ESMJumpToGraphBehavior : byte
	{
		// Token: 0x04015045 RID: 86085
		PreferLocalGraph,
		// Token: 0x04015046 RID: 86086
		PreferExternalGraph,
		// Token: 0x04015047 RID: 86087
		ESMJumpToGraphBehavior_MAX
	}
}
