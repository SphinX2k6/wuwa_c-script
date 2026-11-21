using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000B9 RID: 185
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EArithmeticKeyOperation")]
	public enum EArithmeticKeyOperation
	{
		// Token: 0x04000299 RID: 665
		Equal,
		// Token: 0x0400029A RID: 666
		NotEqual,
		// Token: 0x0400029B RID: 667
		Less,
		// Token: 0x0400029C RID: 668
		LessOrEqual,
		// Token: 0x0400029D RID: 669
		Greater,
		// Token: 0x0400029E RID: 670
		GreaterOrEqual,
		// Token: 0x0400029F RID: 671
		EArithmeticKeyOperation_MAX
	}
}
