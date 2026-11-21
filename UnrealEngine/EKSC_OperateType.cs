using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000554 RID: 1364
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_OperateType")]
	public enum EKSC_OperateType : byte
	{
		// Token: 0x04003667 RID: 13927
		OnPress,
		// Token: 0x04003668 RID: 13928
		OnRelease,
		// Token: 0x04003669 RID: 13929
		OnHold,
		// Token: 0x0400366A RID: 13930
		AutoCast,
		// Token: 0x0400366B RID: 13931
		EKSC_MAX
	}
}
