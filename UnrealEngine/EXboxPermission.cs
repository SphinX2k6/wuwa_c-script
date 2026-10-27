using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E9F RID: 7839
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxPermission")]
	public enum EXboxPermission : byte
	{
		// Token: 0x0401020F RID: 66063
		CommunicateUsingText,
		// Token: 0x04010210 RID: 66064
		CommunicateUsingVoice,
		// Token: 0x04010211 RID: 66065
		ViewTargetProfile,
		// Token: 0x04010212 RID: 66066
		ViewTargetGameHistory,
		// Token: 0x04010213 RID: 66067
		ViewTargetVideoHistory,
		// Token: 0x04010214 RID: 66068
		ViewTargetMusicHistory,
		// Token: 0x04010215 RID: 66069
		ViewTargetExerciseInfo,
		// Token: 0x04010216 RID: 66070
		ViewTargetPresence,
		// Token: 0x04010217 RID: 66071
		ViewTargetVideoStatus,
		// Token: 0x04010218 RID: 66072
		ViewTargetMusicStatus,
		// Token: 0x04010219 RID: 66073
		ViewTargetExerciseStatus,
		// Token: 0x0401021A RID: 66074
		ViewTargetMemberList,
		// Token: 0x0401021B RID: 66075
		ViewTargetFriendList,
		// Token: 0x0401021C RID: 66076
		ViewTargetPinnedLists,
		// Token: 0x0401021D RID: 66077
		ViewTargetCaptureRecord,
		// Token: 0x0401021E RID: 66078
		ViewTargetVideoRecord,
		// Token: 0x0401021F RID: 66079
		EXboxPermission_MAX
	}
}
