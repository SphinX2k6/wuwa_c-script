using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020013ED RID: 5101
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayTasks.EGameplayTaskRunResult")]
	public enum EGameplayTaskRunResult : byte
	{
		// Token: 0x04009F5B RID: 40795
		Error,
		// Token: 0x04009F5C RID: 40796
		Failed,
		// Token: 0x04009F5D RID: 40797
		Success_Paused,
		// Token: 0x04009F5E RID: 40798
		Success_Active,
		// Token: 0x04009F5F RID: 40799
		Success_Finished,
		// Token: 0x04009F60 RID: 40800
		EGameplayTaskRunResult_MAX
	}
}
