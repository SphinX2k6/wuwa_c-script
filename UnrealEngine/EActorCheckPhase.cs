using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015E8 RID: 5608
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroActorFolderCheck.EActorCheckPhase")]
	public enum EActorCheckPhase : byte
	{
		// Token: 0x0400AFED RID: 45037
		PreCheck,
		// Token: 0x0400AFEE RID: 45038
		NormalCheck,
		// Token: 0x0400AFEF RID: 45039
		Modify,
		// Token: 0x0400AFF0 RID: 45040
		ApplyResult,
		// Token: 0x0400AFF1 RID: 45041
		EActorCheckPhase_MAX
	}
}
