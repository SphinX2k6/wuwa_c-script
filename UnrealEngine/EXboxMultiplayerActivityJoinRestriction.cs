using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E9E RID: 7838
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxMultiplayerActivityJoinRestriction")]
	public enum EXboxMultiplayerActivityJoinRestriction : byte
	{
		// Token: 0x0401020A RID: 66058
		Activity_Public,
		// Token: 0x0401020B RID: 66059
		Activity_InviteOnly,
		// Token: 0x0401020C RID: 66060
		Activity_Followed,
		// Token: 0x0401020D RID: 66061
		Activity_MAX
	}
}
