using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000712 RID: 1810
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EAutomationEventType")]
	public enum EAutomationEventType : byte
	{
		// Token: 0x04002DC2 RID: 11714
		Info,
		// Token: 0x04002DC3 RID: 11715
		Warning,
		// Token: 0x04002DC4 RID: 11716
		Error,
		// Token: 0x04002DC5 RID: 11717
		EAutomationEventType_MAX
	}
}
