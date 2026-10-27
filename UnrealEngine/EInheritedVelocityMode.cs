using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016D9 RID: 5849
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EInheritedVelocityMode")]
	public enum EInheritedVelocityMode : byte
	{
		// Token: 0x0400B857 RID: 47191
		None,
		// Token: 0x0400B858 RID: 47192
		AffectDirection,
		// Token: 0x0400B859 RID: 47193
		AffectSpeedAndDirection,
		// Token: 0x0400B85A RID: 47194
		EInheritedVelocityMode_MAX
	}
}
