using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015ED RID: 5613
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroActorFolderCheck.EKuroCheckTier")]
	public enum EKuroCheckTier : byte
	{
		// Token: 0x0400B008 RID: 45064
		Realtime,
		// Token: 0x0400B009 RID: 45065
		Daily,
		// Token: 0x0400B00A RID: 45066
		EKuroCheckTier_MAX
	}
}
