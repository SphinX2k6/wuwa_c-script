using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A49 RID: 6729
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroShaderFrequency")]
	public enum EKuroShaderFrequency : byte
	{
		// Token: 0x0400D74F RID: 55119
		KURO_SF_Pixel,
		// Token: 0x0400D750 RID: 55120
		KURO_SF_Vertex,
		// Token: 0x0400D751 RID: 55121
		KURO_SF_Geometry,
		// Token: 0x0400D752 RID: 55122
		KURO_SF_Hull,
		// Token: 0x0400D753 RID: 55123
		KURO_SF_Domain,
		// Token: 0x0400D754 RID: 55124
		KURO_SF_Compute,
		// Token: 0x0400D755 RID: 55125
		KURO_SF_Max,
		// Token: 0x0400D756 RID: 55126
		KURO_SF_MAX
	}
}
