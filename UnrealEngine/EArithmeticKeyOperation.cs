using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000170 RID: 368
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EArithmeticKeyOperation")]
	public enum EArithmeticKeyOperation
	{
		// Token: 0x04000651 RID: 1617
		Equal,
		// Token: 0x04000652 RID: 1618
		NotEqual,
		// Token: 0x04000653 RID: 1619
		Less,
		// Token: 0x04000654 RID: 1620
		LessOrEqual,
		// Token: 0x04000655 RID: 1621
		Greater,
		// Token: 0x04000656 RID: 1622
		GreaterOrEqual,
		// Token: 0x04000657 RID: 1623
		EArithmeticKeyOperation_MAX
	}
}
