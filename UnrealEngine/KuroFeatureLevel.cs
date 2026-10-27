using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001AF0 RID: 6896
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFeatureLevel")]
	public enum KuroFeatureLevel : byte
	{
		// Token: 0x0400DFF7 RID: 57335
		ES3_1,
		// Token: 0x0400DFF8 RID: 57336
		SM5,
		// Token: 0x0400DFF9 RID: 57337
		KuroFeatureLevel_MAX
	}
}
