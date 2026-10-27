using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020011D0 RID: 4560
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.TextureAddress")]
	public enum TextureAddress
	{
		// Token: 0x04008FC4 RID: 36804
		TA_Wrap,
		// Token: 0x04008FC5 RID: 36805
		TA_Clamp,
		// Token: 0x04008FC6 RID: 36806
		TA_Mirror,
		// Token: 0x04008FC7 RID: 36807
		TA_MAX
	}
}
