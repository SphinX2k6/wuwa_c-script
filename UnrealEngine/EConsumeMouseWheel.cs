using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027FA RID: 10234
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EConsumeMouseWheel")]
	public enum EConsumeMouseWheel : byte
	{
		// Token: 0x04014D63 RID: 85347
		WhenScrollingPossible,
		// Token: 0x04014D64 RID: 85348
		Always,
		// Token: 0x04014D65 RID: 85349
		Never,
		// Token: 0x04014D66 RID: 85350
		EConsumeMouseWheel_MAX
	}
}
