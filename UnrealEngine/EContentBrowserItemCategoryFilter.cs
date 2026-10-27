using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A9 RID: 1193
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ContentBrowserData.EContentBrowserItemCategoryFilter")]
	public enum EContentBrowserItemCategoryFilter : byte
	{
		// Token: 0x04001E55 RID: 7765
		IncludeNone,
		// Token: 0x04001E56 RID: 7766
		IncludeAssets,
		// Token: 0x04001E57 RID: 7767
		IncludeClasses,
		// Token: 0x04001E58 RID: 7768
		IncludeCollections = 4,
		// Token: 0x04001E59 RID: 7769
		IncludeMisc = 8,
		// Token: 0x04001E5A RID: 7770
		IncludeAll = 15,
		// Token: 0x04001E5B RID: 7771
		EContentBrowserItemCategoryFilter_MAX
	}
}
