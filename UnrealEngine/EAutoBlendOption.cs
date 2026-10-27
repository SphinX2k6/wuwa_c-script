using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022B6 RID: 8886
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshBlend.EAutoBlendOption")]
	public enum EAutoBlendOption : byte
	{
		// Token: 0x04012048 RID: 73800
		Small,
		// Token: 0x04012049 RID: 73801
		Medium,
		// Token: 0x0401204A RID: 73802
		Large,
		// Token: 0x0401204B RID: 73803
		Extra_Large,
		// Token: 0x0401204C RID: 73804
		Disabled,
		// Token: 0x0401204D RID: 73805
		EAutoBlendOption_MAX
	}
}
