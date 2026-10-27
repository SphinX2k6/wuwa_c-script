using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002803 RID: 10243
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.ENavigationGenesis")]
	public enum ENavigationGenesis : byte
	{
		// Token: 0x04014DB6 RID: 85430
		Keyboard,
		// Token: 0x04014DB7 RID: 85431
		Controller,
		// Token: 0x04014DB8 RID: 85432
		User,
		// Token: 0x04014DB9 RID: 85433
		ENavigationGenesis_MAX
	}
}
