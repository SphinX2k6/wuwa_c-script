using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000819 RID: 2073
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EUINavigation")]
	public enum EUINavigation : byte
	{
		// Token: 0x0400520A RID: 21002
		Left,
		// Token: 0x0400520B RID: 21003
		Right,
		// Token: 0x0400520C RID: 21004
		Up,
		// Token: 0x0400520D RID: 21005
		Down,
		// Token: 0x0400520E RID: 21006
		Next,
		// Token: 0x0400520F RID: 21007
		Previous,
		// Token: 0x04005210 RID: 21008
		Num,
		// Token: 0x04005211 RID: 21009
		Invalid,
		// Token: 0x04005212 RID: 21010
		EUINavigation_MAX
	}
}
