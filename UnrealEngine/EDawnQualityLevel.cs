using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200291D RID: 10525
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.EDawnQualityLevel")]
	public enum EDawnQualityLevel
	{
		// Token: 0x04015680 RID: 87680
		Preview,
		// Token: 0x04015681 RID: 87681
		Medium,
		// Token: 0x04015682 RID: 87682
		High,
		// Token: 0x04015683 RID: 87683
		Production,
		// Token: 0x04015684 RID: 87684
		EDawnQualityLevel_MAX
	}
}
