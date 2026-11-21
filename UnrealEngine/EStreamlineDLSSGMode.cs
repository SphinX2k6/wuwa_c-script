using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000845 RID: 2117
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineDLSSGBlueprint.EStreamlineDLSSGMode")]
	public enum EStreamlineDLSSGMode : byte
	{
		// Token: 0x040053EA RID: 21482
		Off,
		// Token: 0x040053EB RID: 21483
		Auto = 251,
		// Token: 0x040053EC RID: 21484
		On2X = 17,
		// Token: 0x040053ED RID: 21485
		On3X = 23,
		// Token: 0x040053EE RID: 21486
		On4X = 31,
		// Token: 0x040053EF RID: 21487
		On5X = 37,
		// Token: 0x040053F0 RID: 21488
		On6X = 59,
		// Token: 0x040053F1 RID: 21489
		EStreamlineDLSSGMode_MAX = 252
	}
}
