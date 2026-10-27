using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016E0 RID: 5856
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletInitVelocityDirection")]
	public enum EKuroBulletInitVelocityDirection : byte
	{
		// Token: 0x0400B884 RID: 47236
		Default,
		// Token: 0x0400B885 RID: 47237
		ToTarget,
		// Token: 0x0400B886 RID: 47238
		ToOwner,
		// Token: 0x0400B887 RID: 47239
		Parent,
		// Token: 0x0400B888 RID: 47240
		EKuroBulletInitVelocityDirection_MAX
	}
}
