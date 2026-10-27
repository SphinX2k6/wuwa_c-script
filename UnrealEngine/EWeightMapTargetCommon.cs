using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000487 RID: 1159
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.EWeightMapTargetCommon")]
	public enum EWeightMapTargetCommon : byte
	{
		// Token: 0x04001D61 RID: 7521
		None,
		// Token: 0x04001D62 RID: 7522
		MaxDistance,
		// Token: 0x04001D63 RID: 7523
		BackstopDistance,
		// Token: 0x04001D64 RID: 7524
		BackstopRadius,
		// Token: 0x04001D65 RID: 7525
		AnimDriveMultiplier,
		// Token: 0x04001D66 RID: 7526
		EWeightMapTargetCommon_MAX
	}
}
