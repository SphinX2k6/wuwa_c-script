using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002688 RID: 9864
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Renderer.ESparseVolumeTexturePreviewAttribute")]
	public enum ESparseVolumeTexturePreviewAttribute : byte
	{
		// Token: 0x04013AFE RID: 80638
		ESVTPA_AttributesA_R,
		// Token: 0x04013AFF RID: 80639
		ESVTPA_AttributesA_G,
		// Token: 0x04013B00 RID: 80640
		ESVTPA_AttributesA_B,
		// Token: 0x04013B01 RID: 80641
		ESVTPA_AttributesA_A,
		// Token: 0x04013B02 RID: 80642
		ESVTPA_AttributesB_R,
		// Token: 0x04013B03 RID: 80643
		ESVTPA_AttributesB_G,
		// Token: 0x04013B04 RID: 80644
		ESVTPA_AttributesB_B,
		// Token: 0x04013B05 RID: 80645
		ESVTPA_AttributesB_A,
		// Token: 0x04013B06 RID: 80646
		ESVTPA_MAX
	}
}
