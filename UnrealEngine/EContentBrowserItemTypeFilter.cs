using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004AA RID: 1194
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ContentBrowserData.EContentBrowserItemTypeFilter")]
	public enum EContentBrowserItemTypeFilter : byte
	{
		// Token: 0x04001E5D RID: 7773
		IncludeNone,
		// Token: 0x04001E5E RID: 7774
		IncludeFolders,
		// Token: 0x04001E5F RID: 7775
		IncludeFiles,
		// Token: 0x04001E60 RID: 7776
		IncludeAll,
		// Token: 0x04001E61 RID: 7777
		EContentBrowserItemTypeFilter_MAX
	}
}
