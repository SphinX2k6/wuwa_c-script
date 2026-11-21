using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020005C2 RID: 1474
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxPermission")]
	public enum EXboxPermission : byte
	{
		// Token: 0x04003946 RID: 14662
		CommunicateUsingText,
		// Token: 0x04003947 RID: 14663
		CommunicateUsingVoice,
		// Token: 0x04003948 RID: 14664
		ViewTargetProfile,
		// Token: 0x04003949 RID: 14665
		ViewTargetGameHistory,
		// Token: 0x0400394A RID: 14666
		ViewTargetVideoHistory,
		// Token: 0x0400394B RID: 14667
		ViewTargetMusicHistory,
		// Token: 0x0400394C RID: 14668
		ViewTargetExerciseInfo,
		// Token: 0x0400394D RID: 14669
		ViewTargetPresence,
		// Token: 0x0400394E RID: 14670
		ViewTargetVideoStatus,
		// Token: 0x0400394F RID: 14671
		ViewTargetMusicStatus,
		// Token: 0x04003950 RID: 14672
		ViewTargetExerciseStatus,
		// Token: 0x04003951 RID: 14673
		ViewTargetMemberList,
		// Token: 0x04003952 RID: 14674
		ViewTargetFriendList,
		// Token: 0x04003953 RID: 14675
		ViewTargetPinnedLists,
		// Token: 0x04003954 RID: 14676
		ViewTargetCaptureRecord,
		// Token: 0x04003955 RID: 14677
		ViewTargetVideoRecord,
		// Token: 0x04003956 RID: 14678
		EXboxPermission_MAX
	}
}
