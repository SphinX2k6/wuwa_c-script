using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A6E RID: 2670
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFixedFoveationLevels")]
	public enum EFixedFoveationLevels
	{
		// Token: 0x040047A3 RID: 18339
		Disabled,
		// Token: 0x040047A4 RID: 18340
		Low,
		// Token: 0x040047A5 RID: 18341
		Medium,
		// Token: 0x040047A6 RID: 18342
		High,
		// Token: 0x040047A7 RID: 18343
		HighTop,
		// Token: 0x040047A8 RID: 18344
		EFixedFoveationLevels_MAX
	}
}
