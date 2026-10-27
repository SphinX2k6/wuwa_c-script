using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B8F RID: 2959
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureSizingType")]
	public enum ETextureSizingType
	{
		// Token: 0x04005173 RID: 20851
		TextureSizingType_UseSingleTextureSize,
		// Token: 0x04005174 RID: 20852
		TextureSizingType_UseAutomaticBiasedSizes,
		// Token: 0x04005175 RID: 20853
		TextureSizingType_UseManualOverrideTextureSize,
		// Token: 0x04005176 RID: 20854
		TextureSizingType_UseSimplygonAutomaticSizing,
		// Token: 0x04005177 RID: 20855
		TextureSizingType_MAX
	}
}
