using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B00 RID: 2816
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EOpacityMicromapFormat")]
	public enum EOpacityMicromapFormat : ushort
	{
		// Token: 0x04004D33 RID: 19763
		OMF_Invalid,
		// Token: 0x04004D34 RID: 19764
		OMF_2State,
		// Token: 0x04004D35 RID: 19765
		OMF_4State,
		// Token: 0x04004D36 RID: 19766
		OMF_MAX
	}
}
