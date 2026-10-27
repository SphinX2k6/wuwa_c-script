using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200042F RID: 1071
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/BlueprintGraph.ETunnelBoundaryType")]
	public enum ETunnelBoundaryType : byte
	{
		// Token: 0x04001A30 RID: 6704
		Unknown,
		// Token: 0x04001A31 RID: 6705
		EntrySite,
		// Token: 0x04001A32 RID: 6706
		InputSite,
		// Token: 0x04001A33 RID: 6707
		OutputSite,
		// Token: 0x04001A34 RID: 6708
		ETunnelBoundaryType_MAX
	}
}
