using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A73 RID: 2675
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFormatArgumentType")]
	public enum EFormatArgumentType
	{
		// Token: 0x040047BF RID: 18367
		Int,
		// Token: 0x040047C0 RID: 18368
		UInt,
		// Token: 0x040047C1 RID: 18369
		Float,
		// Token: 0x040047C2 RID: 18370
		Double,
		// Token: 0x040047C3 RID: 18371
		Text,
		// Token: 0x040047C4 RID: 18372
		Gender,
		// Token: 0x040047C5 RID: 18373
		EFormatArgumentType_MAX
	}
}
