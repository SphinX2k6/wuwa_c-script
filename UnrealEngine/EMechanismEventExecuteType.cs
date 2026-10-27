using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019CC RID: 6604
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.EMechanismEventExecuteType")]
	public enum EMechanismEventExecuteType : byte
	{
		// Token: 0x0400D41E RID: 54302
		Trigger,
		// Token: 0x0400D41F RID: 54303
		Start,
		// Token: 0x0400D420 RID: 54304
		Tick,
		// Token: 0x0400D421 RID: 54305
		End,
		// Token: 0x0400D422 RID: 54306
		EMechanismEventExecuteType_MAX
	}
}
