using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C3B RID: 7227
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroResourceCheckTool.EKuroMaterialOverrideTarget")]
	public enum EKuroMaterialOverrideTarget : byte
	{
		// Token: 0x0400F0F0 RID: 61680
		MobileOverride,
		// Token: 0x0400F0F1 RID: 61681
		PCOverride,
		// Token: 0x0400F0F2 RID: 61682
		EKuroMaterialOverrideTarget_MAX
	}
}
