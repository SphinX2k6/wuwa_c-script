using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001C5 RID: 453
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.ETextKeyOperation")]
	public enum ETextKeyOperation
	{
		// Token: 0x0400089B RID: 2203
		Equal,
		// Token: 0x0400089C RID: 2204
		NotEqual,
		// Token: 0x0400089D RID: 2205
		Contain,
		// Token: 0x0400089E RID: 2206
		NotContain,
		// Token: 0x0400089F RID: 2207
		ETextKeyOperation_MAX
	}
}
