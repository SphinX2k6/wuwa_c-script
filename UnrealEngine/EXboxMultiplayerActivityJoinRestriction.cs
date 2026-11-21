using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020005C1 RID: 1473
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxMultiplayerActivityJoinRestriction")]
	public enum EXboxMultiplayerActivityJoinRestriction : byte
	{
		// Token: 0x04003941 RID: 14657
		Activity_Public,
		// Token: 0x04003942 RID: 14658
		Activity_InviteOnly,
		// Token: 0x04003943 RID: 14659
		Activity_Followed,
		// Token: 0x04003944 RID: 14660
		Activity_MAX
	}
}
