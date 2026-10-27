using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016DD RID: 5853
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletFollowType")]
	public enum EKuroBulletFollowType : byte
	{
		// Token: 0x0400B873 RID: 47219
		StaticPosition,
		// Token: 0x0400B874 RID: 47220
		FollowSkeleton,
		// Token: 0x0400B875 RID: 47221
		EKuroBulletFollowType_MAX
	}
}
