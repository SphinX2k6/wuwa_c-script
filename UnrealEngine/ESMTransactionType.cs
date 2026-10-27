using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200286D RID: 10349
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ESMTransactionType")]
	public enum ESMTransactionType : byte
	{
		// Token: 0x04015070 RID: 86128
		SM_Unknown,
		// Token: 0x04015071 RID: 86129
		SM_Transition,
		// Token: 0x04015072 RID: 86130
		SM_State,
		// Token: 0x04015073 RID: 86131
		SM_FullSync,
		// Token: 0x04015074 RID: 86132
		SM_Start,
		// Token: 0x04015075 RID: 86133
		SM_Stop,
		// Token: 0x04015076 RID: 86134
		SM_Initialize,
		// Token: 0x04015077 RID: 86135
		SM_Shutdown,
		// Token: 0x04015078 RID: 86136
		SM_MAX
	}
}
