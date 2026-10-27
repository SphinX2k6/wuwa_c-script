using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A6F RID: 10863
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WwiseFileHandler.EKuroWwiseTaskPriority")]
	public enum EKuroWwiseTaskPriority
	{
		// Token: 0x04015FCE RID: 90062
		High = 1279,
		// Token: 0x04015FCF RID: 90063
		Normal = 255,
		// Token: 0x04015FD0 RID: 90064
		Default = 255,
		// Token: 0x04015FD1 RID: 90065
		BackgroundHigh = 2815,
		// Token: 0x04015FD2 RID: 90066
		BackgroundNormal = 2303,
		// Token: 0x04015FD3 RID: 90067
		BackgroundLow = 2303,
		// Token: 0x04015FD4 RID: 90068
		EKuroWwiseTaskPriority_MAX = 2816
	}
}
