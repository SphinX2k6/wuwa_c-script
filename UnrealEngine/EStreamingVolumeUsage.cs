using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B7E RID: 2942
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStreamingVolumeUsage")]
	public enum EStreamingVolumeUsage
	{
		// Token: 0x040050FD RID: 20733
		SVB_Loading,
		// Token: 0x040050FE RID: 20734
		SVB_LoadingAndVisibility,
		// Token: 0x040050FF RID: 20735
		SVB_VisibilityBlockingOnLoad,
		// Token: 0x04005100 RID: 20736
		SVB_BlockingOnLoad,
		// Token: 0x04005101 RID: 20737
		SVB_LoadingNotVisible,
		// Token: 0x04005102 RID: 20738
		SVB_MAX
	}
}
