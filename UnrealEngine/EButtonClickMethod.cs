using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027F5 RID: 10229
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EButtonClickMethod")]
	public enum EButtonClickMethod
	{
		// Token: 0x04014D48 RID: 85320
		DownAndUp,
		// Token: 0x04014D49 RID: 85321
		MouseDown,
		// Token: 0x04014D4A RID: 85322
		MouseUp,
		// Token: 0x04014D4B RID: 85323
		PreciseClick,
		// Token: 0x04014D4C RID: 85324
		EButtonClickMethod_MAX
	}
}
