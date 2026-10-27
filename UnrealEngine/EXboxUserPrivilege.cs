using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001EA0 RID: 7840
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxUserPrivilege")]
	public enum EXboxUserPrivilege : byte
	{
		// Token: 0x04010221 RID: 66081
		CrossPlay,
		// Token: 0x04010222 RID: 66082
		Clubs,
		// Token: 0x04010223 RID: 66083
		Sessions,
		// Token: 0x04010224 RID: 66084
		Broadcast,
		// Token: 0x04010225 RID: 66085
		ManageProfilePrivacy,
		// Token: 0x04010226 RID: 66086
		GameDvr,
		// Token: 0x04010227 RID: 66087
		MultiplayerParties,
		// Token: 0x04010228 RID: 66088
		CloudManageSession,
		// Token: 0x04010229 RID: 66089
		CloudJoinSession,
		// Token: 0x0401022A RID: 66090
		CloudSavedGames,
		// Token: 0x0401022B RID: 66091
		SocialNetworkSharing,
		// Token: 0x0401022C RID: 66092
		UserGeneratedContent,
		// Token: 0x0401022D RID: 66093
		Communications,
		// Token: 0x0401022E RID: 66094
		Multiplayer,
		// Token: 0x0401022F RID: 66095
		AddFriends,
		// Token: 0x04010230 RID: 66096
		EXboxUserPrivilege_MAX
	}
}
