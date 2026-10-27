using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009EF RID: 2543
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimLinkMethod")]
	public enum EAnimLinkMethod
	{
		// Token: 0x0400443D RID: 17469
		Absolute,
		// Token: 0x0400443E RID: 17470
		Relative,
		// Token: 0x0400443F RID: 17471
		Proportional,
		// Token: 0x04004440 RID: 17472
		EAnimLinkMethod_MAX
	}
}
