using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A8 RID: 1192
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ContentBrowserData.EContentBrowserItemAttributeFilter")]
	public enum EContentBrowserItemAttributeFilter : byte
	{
		// Token: 0x04001E4C RID: 7756
		IncludeNone,
		// Token: 0x04001E4D RID: 7757
		IncludeProject,
		// Token: 0x04001E4E RID: 7758
		IncludeEngine,
		// Token: 0x04001E4F RID: 7759
		IncludePlugins = 4,
		// Token: 0x04001E50 RID: 7760
		IncludeDeveloper = 8,
		// Token: 0x04001E51 RID: 7761
		IncludeLocalized = 16,
		// Token: 0x04001E52 RID: 7762
		IncludeAll = 31,
		// Token: 0x04001E53 RID: 7763
		EContentBrowserItemAttributeFilter_MAX
	}
}
