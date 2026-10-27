using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200016D RID: 365
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EAIParamType")]
	public enum EAIParamType : byte
	{
		// Token: 0x04000641 RID: 1601
		Float,
		// Token: 0x04000642 RID: 1602
		Int,
		// Token: 0x04000643 RID: 1603
		Bool,
		// Token: 0x04000644 RID: 1604
		MAX
	}
}
