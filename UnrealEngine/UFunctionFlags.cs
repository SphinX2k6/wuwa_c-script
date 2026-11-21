using System;

namespace UnrealEngine
{
	// Token: 0x02000886 RID: 2182
	[Flags]
	public enum UFunctionFlags : uint
	{
		// Token: 0x0400565B RID: 22107
		FUNC_None = 0U,
		// Token: 0x0400565C RID: 22108
		INTERNAL_FUNC_Final = 1U,
		// Token: 0x0400565D RID: 22109
		FUNC_RequiredAPI = 2U,
		// Token: 0x0400565E RID: 22110
		FUNC_BlueprintAuthorityOnly = 4U,
		// Token: 0x0400565F RID: 22111
		FUNC_BlueprintCosmetic = 8U,
		// Token: 0x04005660 RID: 22112
		FUNC_Net = 64U,
		// Token: 0x04005661 RID: 22113
		FUNC_NetReliable = 128U,
		// Token: 0x04005662 RID: 22114
		FUNC_NetRequest = 256U,
		// Token: 0x04005663 RID: 22115
		FUNC_Exec = 512U,
		// Token: 0x04005664 RID: 22116
		FUNC_Native = 1024U,
		// Token: 0x04005665 RID: 22117
		FUNC_Event = 2048U,
		// Token: 0x04005666 RID: 22118
		FUNC_NetResponse = 4096U,
		// Token: 0x04005667 RID: 22119
		INTERNAL_FUNC_Static = 8192U,
		// Token: 0x04005668 RID: 22120
		FUNC_NetMulticast = 16384U,
		// Token: 0x04005669 RID: 22121
		FUNC_UbergraphFunction = 32768U,
		// Token: 0x0400566A RID: 22122
		FUNC_MulticastDelegate = 65536U,
		// Token: 0x0400566B RID: 22123
		FUNC_Public = 131072U,
		// Token: 0x0400566C RID: 22124
		FUNC_Private = 262144U,
		// Token: 0x0400566D RID: 22125
		FUNC_Protected = 524288U,
		// Token: 0x0400566E RID: 22126
		FUNC_Delegate = 1048576U,
		// Token: 0x0400566F RID: 22127
		FUNC_NetServer = 2097152U,
		// Token: 0x04005670 RID: 22128
		FUNC_HasOutParms = 4194304U,
		// Token: 0x04005671 RID: 22129
		FUNC_HasDefaults = 8388608U,
		// Token: 0x04005672 RID: 22130
		FUNC_NetClient = 16777216U,
		// Token: 0x04005673 RID: 22131
		FUNC_DLLImport = 33554432U,
		// Token: 0x04005674 RID: 22132
		FUNC_BlueprintCallable = 67108864U,
		// Token: 0x04005675 RID: 22133
		FUNC_BlueprintEvent = 134217728U,
		// Token: 0x04005676 RID: 22134
		FUNC_BlueprintPure = 268435456U,
		// Token: 0x04005677 RID: 22135
		FUNC_EditorOnly = 536870912U,
		// Token: 0x04005678 RID: 22136
		FUNC_Const = 1073741824U,
		// Token: 0x04005679 RID: 22137
		FUNC_NetValidate = 2147483648U,
		// Token: 0x0400567A RID: 22138
		FUNC_AllFlags = 4294967295U
	}
}
