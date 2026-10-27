using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200280C RID: 10252
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.ETextCommit")]
	public enum ETextCommit
	{
		// Token: 0x04014DE6 RID: 85478
		Default,
		// Token: 0x04014DE7 RID: 85479
		OnEnter,
		// Token: 0x04014DE8 RID: 85480
		OnUserMovedFocus,
		// Token: 0x04014DE9 RID: 85481
		OnCleared,
		// Token: 0x04014DEA RID: 85482
		ETextCommit_MAX
	}
}
