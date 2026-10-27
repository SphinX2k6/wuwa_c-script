using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A9B RID: 2715
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELandscapeCullingPrecision")]
	public enum ELandscapeCullingPrecision
	{
		// Token: 0x04004900 RID: 18688
		High,
		// Token: 0x04004901 RID: 18689
		Medium,
		// Token: 0x04004902 RID: 18690
		Low,
		// Token: 0x04004903 RID: 18691
		ELandscapeCullingPrecision_MAX
	}
}
