using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016E4 RID: 5860
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletPositionStandard")]
	public enum EKuroBulletPositionStandard : byte
	{
		// Token: 0x0400B89D RID: 47261
		Owner,
		// Token: 0x0400B89E RID: 47262
		SkillTarget,
		// Token: 0x0400B89F RID: 47263
		Parent = 3,
		// Token: 0x0400B8A0 RID: 47264
		EKuroBulletPositionStandard_MAX
	}
}
