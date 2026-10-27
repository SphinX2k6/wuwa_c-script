using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027F6 RID: 10230
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EButtonPressMethod")]
	public enum EButtonPressMethod
	{
		// Token: 0x04014D4E RID: 85326
		DownAndUp,
		// Token: 0x04014D4F RID: 85327
		ButtonPress,
		// Token: 0x04014D50 RID: 85328
		ButtonRelease,
		// Token: 0x04014D51 RID: 85329
		EButtonPressMethod_MAX
	}
}
