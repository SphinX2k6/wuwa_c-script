using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FE9 RID: 8169
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EMouseButtonType")]
	public enum EMouseButtonType : byte
	{
		// Token: 0x04010BA7 RID: 68519
		Left,
		// Token: 0x04010BA8 RID: 68520
		Middle,
		// Token: 0x04010BA9 RID: 68521
		Right,
		// Token: 0x04010BAA RID: 68522
		UserDefined1,
		// Token: 0x04010BAB RID: 68523
		UserDefined2,
		// Token: 0x04010BAC RID: 68524
		UserDefined3,
		// Token: 0x04010BAD RID: 68525
		UserDefined4,
		// Token: 0x04010BAE RID: 68526
		UserDefined5,
		// Token: 0x04010BAF RID: 68527
		UserDefined6,
		// Token: 0x04010BB0 RID: 68528
		UserDefined7,
		// Token: 0x04010BB1 RID: 68529
		UserDefined8,
		// Token: 0x04010BB2 RID: 68530
		NavigationChange,
		// Token: 0x04010BB3 RID: 68531
		EMouseButtonType_MAX
	}
}
