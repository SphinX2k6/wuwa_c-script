using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000460 RID: 1120
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.EMechanismEventExecuteType")]
	public enum EMechanismEventExecuteType : byte
	{
		// Token: 0x04002DB3 RID: 11699
		Trigger,
		// Token: 0x04002DB4 RID: 11700
		Start,
		// Token: 0x04002DB5 RID: 11701
		Tick,
		// Token: 0x04002DB6 RID: 11702
		End,
		// Token: 0x04002DB7 RID: 11703
		EMechanismEventExecuteType_MAX
	}
}
