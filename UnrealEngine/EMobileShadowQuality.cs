using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200228B RID: 8843
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MaterialShaderQualitySettings.EMobileShadowQuality")]
	public enum EMobileShadowQuality : byte
	{
		// Token: 0x04011F2E RID: 73518
		NoFiltering,
		// Token: 0x04011F2F RID: 73519
		PCF_1x1,
		// Token: 0x04011F30 RID: 73520
		PCF_2x2,
		// Token: 0x04011F31 RID: 73521
		PCF_3x3,
		// Token: 0x04011F32 RID: 73522
		EMobileShadowQuality_MAX
	}
}
