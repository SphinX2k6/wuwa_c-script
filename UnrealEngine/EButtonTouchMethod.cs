using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027F7 RID: 10231
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EButtonTouchMethod")]
	public enum EButtonTouchMethod
	{
		// Token: 0x04014D53 RID: 85331
		DownAndUp,
		// Token: 0x04014D54 RID: 85332
		Down,
		// Token: 0x04014D55 RID: 85333
		PreciseTap,
		// Token: 0x04014D56 RID: 85334
		EButtonTouchMethod_MAX
	}
}
