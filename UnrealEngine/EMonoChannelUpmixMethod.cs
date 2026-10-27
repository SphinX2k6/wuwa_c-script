using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AD8 RID: 2776
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMonoChannelUpmixMethod")]
	public enum EMonoChannelUpmixMethod : sbyte
	{
		// Token: 0x04004AEE RID: 19182
		Linear,
		// Token: 0x04004AEF RID: 19183
		EqualPower,
		// Token: 0x04004AF0 RID: 19184
		FullVolume,
		// Token: 0x04004AF1 RID: 19185
		EMonoChannelUpmixMethod_MAX
	}
}
