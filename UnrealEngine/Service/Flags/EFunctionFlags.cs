using System;

namespace UnrealEngine.Service.Flags
{
	// Token: 0x020008B8 RID: 2232
	[Flags]
	public enum EFunctionFlags : uint
	{
		// Token: 0x04005707 RID: 22279
		FUNC_None = 0U,
		// Token: 0x04005708 RID: 22280
		FUNC_Final = 1U,
		// Token: 0x04005709 RID: 22281
		FUNC_RequiredAPI = 2U,
		// Token: 0x0400570A RID: 22282
		FUNC_BlueprintAuthorityOnly = 4U,
		// Token: 0x0400570B RID: 22283
		FUNC_BlueprintCosmetic = 8U,
		// Token: 0x0400570C RID: 22284
		FUNC_Net = 64U,
		// Token: 0x0400570D RID: 22285
		FUNC_NetReliable = 128U,
		// Token: 0x0400570E RID: 22286
		FUNC_NetRequest = 256U,
		// Token: 0x0400570F RID: 22287
		FUNC_Exec = 512U,
		// Token: 0x04005710 RID: 22288
		FUNC_Native = 1024U,
		// Token: 0x04005711 RID: 22289
		FUNC_Event = 2048U,
		// Token: 0x04005712 RID: 22290
		FUNC_NetResponse = 4096U,
		// Token: 0x04005713 RID: 22291
		FUNC_Static = 8192U,
		// Token: 0x04005714 RID: 22292
		FUNC_NetMulticast = 16384U,
		// Token: 0x04005715 RID: 22293
		FUNC_UbergraphFunction = 32768U,
		// Token: 0x04005716 RID: 22294
		FUNC_MulticastDelegate = 65536U,
		// Token: 0x04005717 RID: 22295
		FUNC_Public = 131072U,
		// Token: 0x04005718 RID: 22296
		FUNC_Private = 262144U,
		// Token: 0x04005719 RID: 22297
		FUNC_Protected = 524288U,
		// Token: 0x0400571A RID: 22298
		FUNC_Delegate = 1048576U,
		// Token: 0x0400571B RID: 22299
		FUNC_NetServer = 2097152U,
		// Token: 0x0400571C RID: 22300
		FUNC_HasOutParms = 4194304U,
		// Token: 0x0400571D RID: 22301
		FUNC_HasDefaults = 8388608U,
		// Token: 0x0400571E RID: 22302
		FUNC_NetClient = 16777216U,
		// Token: 0x0400571F RID: 22303
		FUNC_DLLImport = 33554432U,
		// Token: 0x04005720 RID: 22304
		FUNC_BlueprintCallable = 67108864U,
		// Token: 0x04005721 RID: 22305
		FUNC_BlueprintEvent = 134217728U,
		// Token: 0x04005722 RID: 22306
		FUNC_BlueprintPure = 268435456U,
		// Token: 0x04005723 RID: 22307
		FUNC_EditorOnly = 536870912U,
		// Token: 0x04005724 RID: 22308
		FUNC_Const = 1073741824U,
		// Token: 0x04005725 RID: 22309
		FUNC_NetValidate = 2147483648U,
		// Token: 0x04005726 RID: 22310
		FUNC_BlueprintNativeEvent = 134220800U,
		// Token: 0x04005727 RID: 22311
		FUNC_BlueprintImplementableEvent = 134219776U,
		// Token: 0x04005728 RID: 22312
		FUNC_AllFlags = 4294967295U
	}
}
