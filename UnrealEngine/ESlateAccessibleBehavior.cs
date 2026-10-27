using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002958 RID: 10584
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.ESlateAccessibleBehavior")]
	public enum ESlateAccessibleBehavior : byte
	{
		// Token: 0x04015890 RID: 88208
		NotAccessible,
		// Token: 0x04015891 RID: 88209
		Auto,
		// Token: 0x04015892 RID: 88210
		Summary,
		// Token: 0x04015893 RID: 88211
		Custom,
		// Token: 0x04015894 RID: 88212
		ToolTip,
		// Token: 0x04015895 RID: 88213
		ESlateAccessibleBehavior_MAX
	}
}
