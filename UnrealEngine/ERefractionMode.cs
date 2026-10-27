using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B42 RID: 2882
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERefractionMode")]
	public enum ERefractionMode
	{
		// Token: 0x04004F63 RID: 20323
		RM_IndexOfRefraction,
		// Token: 0x04004F64 RID: 20324
		RM_PixelNormalOffset,
		// Token: 0x04004F65 RID: 20325
		RM_MAX
	}
}
