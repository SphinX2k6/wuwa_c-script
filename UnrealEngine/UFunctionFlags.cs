using System;

namespace UnrealEngine
{
	// Token: 0x02002AD7 RID: 10967
	[Flags]
	public enum UFunctionFlags : uint
	{
		// Token: 0x04016240 RID: 90688
		FUNC_None = 0U,
		// Token: 0x04016241 RID: 90689
		INTERNAL_FUNC_Final = 1U,
		// Token: 0x04016242 RID: 90690
		FUNC_RequiredAPI = 2U,
		// Token: 0x04016243 RID: 90691
		FUNC_BlueprintAuthorityOnly = 4U,
		// Token: 0x04016244 RID: 90692
		FUNC_BlueprintCosmetic = 8U,
		// Token: 0x04016245 RID: 90693
		FUNC_Net = 64U,
		// Token: 0x04016246 RID: 90694
		FUNC_NetReliable = 128U,
		// Token: 0x04016247 RID: 90695
		FUNC_NetRequest = 256U,
		// Token: 0x04016248 RID: 90696
		FUNC_Exec = 512U,
		// Token: 0x04016249 RID: 90697
		FUNC_Native = 1024U,
		// Token: 0x0401624A RID: 90698
		FUNC_Event = 2048U,
		// Token: 0x0401624B RID: 90699
		FUNC_NetResponse = 4096U,
		// Token: 0x0401624C RID: 90700
		INTERNAL_FUNC_Static = 8192U,
		// Token: 0x0401624D RID: 90701
		FUNC_NetMulticast = 16384U,
		// Token: 0x0401624E RID: 90702
		FUNC_UbergraphFunction = 32768U,
		// Token: 0x0401624F RID: 90703
		FUNC_MulticastDelegate = 65536U,
		// Token: 0x04016250 RID: 90704
		FUNC_Public = 131072U,
		// Token: 0x04016251 RID: 90705
		FUNC_Private = 262144U,
		// Token: 0x04016252 RID: 90706
		FUNC_Protected = 524288U,
		// Token: 0x04016253 RID: 90707
		FUNC_Delegate = 1048576U,
		// Token: 0x04016254 RID: 90708
		FUNC_NetServer = 2097152U,
		// Token: 0x04016255 RID: 90709
		FUNC_HasOutParms = 4194304U,
		// Token: 0x04016256 RID: 90710
		FUNC_HasDefaults = 8388608U,
		// Token: 0x04016257 RID: 90711
		FUNC_NetClient = 16777216U,
		// Token: 0x04016258 RID: 90712
		FUNC_DLLImport = 33554432U,
		// Token: 0x04016259 RID: 90713
		FUNC_BlueprintCallable = 67108864U,
		// Token: 0x0401625A RID: 90714
		FUNC_BlueprintEvent = 134217728U,
		// Token: 0x0401625B RID: 90715
		FUNC_BlueprintPure = 268435456U,
		// Token: 0x0401625C RID: 90716
		FUNC_EditorOnly = 536870912U,
		// Token: 0x0401625D RID: 90717
		FUNC_Const = 1073741824U,
		// Token: 0x0401625E RID: 90718
		FUNC_NetValidate = 2147483648U,
		// Token: 0x0401625F RID: 90719
		FUNC_AllFlags = 4294967295U
	}
}
