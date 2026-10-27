using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A72 RID: 6770
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroCharBodyType")]
	public enum EKuroCharBodyType : byte
	{
		// Token: 0x0400D8FD RID: 55549
		Body,
		// Token: 0x0400D8FE RID: 55550
		Weapon,
		// Token: 0x0400D8FF RID: 55551
		Hulu,
		// Token: 0x0400D900 RID: 55552
		Other,
		// Token: 0x0400D901 RID: 55553
		ExtraBody,
		// Token: 0x0400D902 RID: 55554
		EKuroCharBodyType_Max,
		// Token: 0x0400D903 RID: 55555
		EKuroCharBodyType_MAX
	}
}
