using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002854 RID: 10324
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.ETextTransformPolicy")]
	public enum ETextTransformPolicy : byte
	{
		// Token: 0x04014FF8 RID: 86008
		None,
		// Token: 0x04014FF9 RID: 86009
		ToLower,
		// Token: 0x04014FFA RID: 86010
		ToUpper,
		// Token: 0x04014FFB RID: 86011
		ETextTransformPolicy_MAX
	}
}
