using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016E3 RID: 5859
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletMoveTrajectory")]
	public enum EKuroBulletMoveTrajectory : byte
	{
		// Token: 0x0400B898 RID: 47256
		Default,
		// Token: 0x0400B899 RID: 47257
		Track,
		// Token: 0x0400B89A RID: 47258
		SurroundCenter = 3,
		// Token: 0x0400B89B RID: 47259
		EKuroBulletMoveTrajectory_MAX
	}
}
