using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A2B RID: 10795
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EMaterialSearchLocation")]
	public enum EMaterialSearchLocation : byte
	{
		// Token: 0x04015E3E RID: 89662
		Local,
		// Token: 0x04015E3F RID: 89663
		UnderParent,
		// Token: 0x04015E40 RID: 89664
		UnderRoot,
		// Token: 0x04015E41 RID: 89665
		AllAssets,
		// Token: 0x04015E42 RID: 89666
		DoNotSearch,
		// Token: 0x04015E43 RID: 89667
		EMaterialSearchLocation_MAX
	}
}
