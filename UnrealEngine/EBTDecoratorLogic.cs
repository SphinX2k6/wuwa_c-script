using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000174 RID: 372
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EBTDecoratorLogic")]
	public enum EBTDecoratorLogic
	{
		// Token: 0x04000665 RID: 1637
		Invalid,
		// Token: 0x04000666 RID: 1638
		Test,
		// Token: 0x04000667 RID: 1639
		And,
		// Token: 0x04000668 RID: 1640
		Or,
		// Token: 0x04000669 RID: 1641
		Not,
		// Token: 0x0400066A RID: 1642
		EBTDecoratorLogic_MAX
	}
}
