using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200077C RID: 1916
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/DawnSDKCommon.EDawnSDKJobPriority")]
	public enum EDawnSDKJobPriority
	{
		// Token: 0x0400302A RID: 12330
		Priority_LOW,
		// Token: 0x0400302B RID: 12331
		Priority_MEDIUM,
		// Token: 0x0400302C RID: 12332
		Priority_HIGH,
		// Token: 0x0400302D RID: 12333
		Priority_MAX
	}
}
