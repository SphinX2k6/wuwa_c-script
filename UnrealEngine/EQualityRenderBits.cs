using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002265 RID: 8805
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MagtModule.EQualityRenderBits")]
	public enum EQualityRenderBits : byte
	{
		// Token: 0x04011DBB RID: 73147
		EQC_Resolution,
		// Token: 0x04011DBC RID: 73148
		EQC_ViewDistance,
		// Token: 0x04011DBD RID: 73149
		EQC_GI,
		// Token: 0x04011DBE RID: 73150
		EQC_AntiAliasing,
		// Token: 0x04011DBF RID: 73151
		EQC_PostProcess,
		// Token: 0x04011DC0 RID: 73152
		EQC_Foliage,
		// Token: 0x04011DC1 RID: 73153
		EQC_Shadow,
		// Token: 0x04011DC2 RID: 73154
		EQC_Reflection,
		// Token: 0x04011DC3 RID: 73155
		EQC_Texture,
		// Token: 0x04011DC4 RID: 73156
		EQC_Effects,
		// Token: 0x04011DC5 RID: 73157
		EQC_Shading,
		// Token: 0x04011DC6 RID: 73158
		EQC_MAX
	}
}
