using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200279F RID: 10143
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ESeparateOverlappingChartsMode")]
	public enum ESeparateOverlappingChartsMode : byte
	{
		// Token: 0x04014A45 RID: 84549
		Disabled,
		// Token: 0x04014A46 RID: 84550
		Enabled,
		// Token: 0x04014A47 RID: 84551
		Auto,
		// Token: 0x04014A48 RID: 84552
		ESeparateOverlappingChartsMode_MAX
	}
}
