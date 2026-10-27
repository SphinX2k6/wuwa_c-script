using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002856 RID: 10326
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EUserInterfaceActionType")]
	public enum EUserInterfaceActionType : byte
	{
		// Token: 0x04015001 RID: 86017
		None,
		// Token: 0x04015002 RID: 86018
		Button,
		// Token: 0x04015003 RID: 86019
		ToggleButton,
		// Token: 0x04015004 RID: 86020
		RadioButton,
		// Token: 0x04015005 RID: 86021
		Check,
		// Token: 0x04015006 RID: 86022
		CollapsedButton,
		// Token: 0x04015007 RID: 86023
		EUserInterfaceActionType_MAX
	}
}
