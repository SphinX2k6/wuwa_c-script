using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CB6 RID: 7350
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_AdditionalAttackSourceTarget")]
	public enum EKSC_AdditionalAttackSourceTarget : byte
	{
		// Token: 0x0400F517 RID: 62743
		SourceFriend,
		// Token: 0x0400F518 RID: 62744
		SourceEnemy,
		// Token: 0x0400F519 RID: 62745
		TargetFriend,
		// Token: 0x0400F51A RID: 62746
		TargetEnemy,
		// Token: 0x0400F51B RID: 62747
		EKSC_MAX
	}
}
