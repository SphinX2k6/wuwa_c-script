using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016E6 RID: 5862
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletTarget")]
	public enum EKuroBulletTarget : byte
	{
		// Token: 0x0400B8A9 RID: 47273
		None,
		// Token: 0x0400B8AA RID: 47274
		CurrentRole,
		// Token: 0x0400B8AB RID: 47275
		SkillTarget,
		// Token: 0x0400B8AC RID: 47276
		EKuroBulletTarget_MAX
	}
}
