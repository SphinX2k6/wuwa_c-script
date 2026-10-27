using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002966 RID: 10598
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EWindowVisibility")]
	public enum EWindowVisibility : byte
	{
		// Token: 0x040158D5 RID: 88277
		Visible,
		// Token: 0x040158D6 RID: 88278
		SelfHitTestInvisible,
		// Token: 0x040158D7 RID: 88279
		EWindowVisibility_MAX
	}
}
