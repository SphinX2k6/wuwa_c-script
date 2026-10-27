using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200164B RID: 5707
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ESwingStateType")]
	public enum ESwingStateType : byte
	{
		// Token: 0x0400B387 RID: 45959
		None,
		// Token: 0x0400B388 RID: 45960
		EnterSwing,
		// Token: 0x0400B389 RID: 45961
		LoopSwing,
		// Token: 0x0400B38A RID: 45962
		LeftLoopSwing,
		// Token: 0x0400B38B RID: 45963
		ExitSwing,
		// Token: 0x0400B38C RID: 45964
		ESwingStateType_MAX
	}
}
