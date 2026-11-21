using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004C8 RID: 1224
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFeatureLevel")]
	public enum KuroFeatureLevel : byte
	{
		// Token: 0x040030C2 RID: 12482
		ES3_1,
		// Token: 0x040030C3 RID: 12483
		SM5,
		// Token: 0x040030C4 RID: 12484
		KuroFeatureLevel_MAX
	}
}
