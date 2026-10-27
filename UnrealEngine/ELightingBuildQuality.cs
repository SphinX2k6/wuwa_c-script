using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA3 RID: 2723
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELightingBuildQuality")]
	public enum ELightingBuildQuality
	{
		// Token: 0x0400492E RID: 18734
		Quality_Preview,
		// Token: 0x0400492F RID: 18735
		Quality_Medium,
		// Token: 0x04004930 RID: 18736
		Quality_High,
		// Token: 0x04004931 RID: 18737
		Quality_Production,
		// Token: 0x04004932 RID: 18738
		Quality_MAX
	}
}
