using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200280E RID: 10254
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EUINavigation")]
	public enum EUINavigation : byte
	{
		// Token: 0x04014DF1 RID: 85489
		Left,
		// Token: 0x04014DF2 RID: 85490
		Right,
		// Token: 0x04014DF3 RID: 85491
		Up,
		// Token: 0x04014DF4 RID: 85492
		Down,
		// Token: 0x04014DF5 RID: 85493
		Next,
		// Token: 0x04014DF6 RID: 85494
		Previous,
		// Token: 0x04014DF7 RID: 85495
		Num,
		// Token: 0x04014DF8 RID: 85496
		Invalid,
		// Token: 0x04014DF9 RID: 85497
		EUINavigation_MAX
	}
}
