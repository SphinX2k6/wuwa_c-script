using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020017E1 RID: 6113
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroCreatePack.EToJsonMode")]
	public enum EToJsonMode : byte
	{
		// Token: 0x0400C42C RID: 50220
		Full,
		// Token: 0x0400C42D RID: 50221
		Simple,
		// Token: 0x0400C42E RID: 50222
		VerySimple,
		// Token: 0x0400C42F RID: 50223
		EToJsonMode_MAX
	}
}
