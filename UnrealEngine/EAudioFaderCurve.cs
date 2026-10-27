using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009FD RID: 2557
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAudioFaderCurve")]
	public enum EAudioFaderCurve : byte
	{
		// Token: 0x0400448C RID: 17548
		Linear,
		// Token: 0x0400448D RID: 17549
		Logarithmic,
		// Token: 0x0400448E RID: 17550
		SCurve,
		// Token: 0x0400448F RID: 17551
		Sin,
		// Token: 0x04004490 RID: 17552
		Count,
		// Token: 0x04004491 RID: 17553
		EAudioFaderCurve_MAX
	}
}
