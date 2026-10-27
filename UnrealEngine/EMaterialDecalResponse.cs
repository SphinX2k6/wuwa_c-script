using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AAF RID: 2735
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialDecalResponse")]
	public enum EMaterialDecalResponse
	{
		// Token: 0x04004969 RID: 18793
		MDR_None,
		// Token: 0x0400496A RID: 18794
		MDR_ColorNormalRoughness,
		// Token: 0x0400496B RID: 18795
		MDR_Color,
		// Token: 0x0400496C RID: 18796
		MDR_ColorNormal,
		// Token: 0x0400496D RID: 18797
		MDR_ColorRoughness,
		// Token: 0x0400496E RID: 18798
		MDR_Normal,
		// Token: 0x0400496F RID: 18799
		MDR_NormalRoughness,
		// Token: 0x04004970 RID: 18800
		MDR_Roughness,
		// Token: 0x04004971 RID: 18801
		MDR_MAX
	}
}
