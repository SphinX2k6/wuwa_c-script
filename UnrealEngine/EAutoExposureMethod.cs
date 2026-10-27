using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A03 RID: 2563
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAutoExposureMethod")]
	public enum EAutoExposureMethod
	{
		// Token: 0x040044AB RID: 17579
		AEM_Histogram,
		// Token: 0x040044AC RID: 17580
		AEM_Basic,
		// Token: 0x040044AD RID: 17581
		AEM_Manual,
		// Token: 0x040044AE RID: 17582
		AEM_MAX
	}
}
