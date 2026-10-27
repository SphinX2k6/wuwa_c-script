using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027FD RID: 10237
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EFlowDirectionPreference")]
	public enum EFlowDirectionPreference : byte
	{
		// Token: 0x04014D8B RID: 85387
		Inherit,
		// Token: 0x04014D8C RID: 85388
		Culture,
		// Token: 0x04014D8D RID: 85389
		LeftToRight,
		// Token: 0x04014D8E RID: 85390
		RightToLeft,
		// Token: 0x04014D8F RID: 85391
		EFlowDirectionPreference_MAX
	}
}
