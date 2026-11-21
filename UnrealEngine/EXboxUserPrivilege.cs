using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020005C3 RID: 1475
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxUserPrivilege")]
	public enum EXboxUserPrivilege : byte
	{
		// Token: 0x04003958 RID: 14680
		CrossPlay,
		// Token: 0x04003959 RID: 14681
		Clubs,
		// Token: 0x0400395A RID: 14682
		Sessions,
		// Token: 0x0400395B RID: 14683
		Broadcast,
		// Token: 0x0400395C RID: 14684
		ManageProfilePrivacy,
		// Token: 0x0400395D RID: 14685
		GameDvr,
		// Token: 0x0400395E RID: 14686
		MultiplayerParties,
		// Token: 0x0400395F RID: 14687
		CloudManageSession,
		// Token: 0x04003960 RID: 14688
		CloudJoinSession,
		// Token: 0x04003961 RID: 14689
		CloudSavedGames,
		// Token: 0x04003962 RID: 14690
		SocialNetworkSharing,
		// Token: 0x04003963 RID: 14691
		UserGeneratedContent,
		// Token: 0x04003964 RID: 14692
		Communications,
		// Token: 0x04003965 RID: 14693
		Multiplayer,
		// Token: 0x04003966 RID: 14694
		AddFriends,
		// Token: 0x04003967 RID: 14695
		EXboxUserPrivilege_MAX
	}
}
