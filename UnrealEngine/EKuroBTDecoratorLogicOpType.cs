using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015F0 RID: 5616
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAiEd.EKuroBTDecoratorLogicOpType")]
	public enum EKuroBTDecoratorLogicOpType : byte
	{
		// Token: 0x0400B019 RID: 45081
		Unknown,
		// Token: 0x0400B01A RID: 45082
		Test,
		// Token: 0x0400B01B RID: 45083
		And,
		// Token: 0x0400B01C RID: 45084
		Or,
		// Token: 0x0400B01D RID: 45085
		Not,
		// Token: 0x0400B01E RID: 45086
		EKuroBTDecoratorLogicOpType_MAX
	}
}
