using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002474 RID: 9332
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NavigationSystem.ERuntimeGenerationType")]
	public enum ERuntimeGenerationType : byte
	{
		// Token: 0x04012A53 RID: 76371
		Static,
		// Token: 0x04012A54 RID: 76372
		DynamicModifiersOnly,
		// Token: 0x04012A55 RID: 76373
		Dynamic,
		// Token: 0x04012A56 RID: 76374
		LegacyGeneration,
		// Token: 0x04012A57 RID: 76375
		ERuntimeGenerationType_MAX
	}
}
