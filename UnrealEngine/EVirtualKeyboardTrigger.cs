using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002858 RID: 10328
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EVirtualKeyboardTrigger")]
	public enum EVirtualKeyboardTrigger : byte
	{
		// Token: 0x0401500E RID: 86030
		OnFocusByPointer,
		// Token: 0x0401500F RID: 86031
		OnAllFocusEvents,
		// Token: 0x04015010 RID: 86032
		EVirtualKeyboardTrigger_MAX
	}
}
