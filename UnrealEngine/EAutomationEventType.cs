using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000FD RID: 253
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EAutomationEventType")]
	public enum EAutomationEventType : byte
	{
		// Token: 0x04000451 RID: 1105
		Info,
		// Token: 0x04000452 RID: 1106
		Warning,
		// Token: 0x04000453 RID: 1107
		Error,
		// Token: 0x04000454 RID: 1108
		EAutomationEventType_MAX
	}
}
