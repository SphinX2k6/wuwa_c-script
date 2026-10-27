using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200149A RID: 5274
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EPDGBakePackageReplaceModeOption")]
	public enum EPDGBakePackageReplaceModeOption : byte
	{
		// Token: 0x0400A4FB RID: 42235
		CreateNewAssets,
		// Token: 0x0400A4FC RID: 42236
		ReplaceExistingAssets,
		// Token: 0x0400A4FD RID: 42237
		EPDGBakePackageReplaceModeOption_MAX
	}
}
