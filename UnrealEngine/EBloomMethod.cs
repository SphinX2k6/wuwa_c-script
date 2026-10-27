using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A0F RID: 2575
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBloomMethod")]
	public enum EBloomMethod
	{
		// Token: 0x040044F8 RID: 17656
		BM_SOG,
		// Token: 0x040044F9 RID: 17657
		BM_FFT,
		// Token: 0x040044FA RID: 17658
		BM_KURO,
		// Token: 0x040044FB RID: 17659
		BM_MAX
	}
}
