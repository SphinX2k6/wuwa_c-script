using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000429 RID: 1065
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/BehaviorTreeEditor.EDecoratorLogicMode")]
	public enum EDecoratorLogicMode
	{
		// Token: 0x040019F7 RID: 6647
		Sink,
		// Token: 0x040019F8 RID: 6648
		And,
		// Token: 0x040019F9 RID: 6649
		Or,
		// Token: 0x040019FA RID: 6650
		Not,
		// Token: 0x040019FB RID: 6651
		EDecoratorLogicMode_MAX
	}
}
