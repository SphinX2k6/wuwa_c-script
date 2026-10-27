using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016DC RID: 5852
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletEffectParam")]
	public enum EKuroBulletEffectParam : byte
	{
		// Token: 0x0400B86D RID: 47213
		None,
		// Token: 0x0400B86E RID: 47214
		RelativeLocation = 2,
		// Token: 0x0400B86F RID: 47215
		RelativeRotation,
		// Token: 0x0400B870 RID: 47216
		Scale,
		// Token: 0x0400B871 RID: 47217
		EKuroBulletEffectParam_MAX
	}
}
