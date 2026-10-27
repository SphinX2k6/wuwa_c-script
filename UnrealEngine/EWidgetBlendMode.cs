using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002960 RID: 10592
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EWidgetBlendMode")]
	public enum EWidgetBlendMode : byte
	{
		// Token: 0x040158BA RID: 88250
		Opaque,
		// Token: 0x040158BB RID: 88251
		Masked,
		// Token: 0x040158BC RID: 88252
		Transparent,
		// Token: 0x040158BD RID: 88253
		EWidgetBlendMode_MAX
	}
}
