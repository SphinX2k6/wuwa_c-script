using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA9 RID: 2729
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELocalExposureMethod")]
	public enum ELocalExposureMethod : byte
	{
		// Token: 0x0400494F RID: 18767
		Disabled,
		// Token: 0x04004950 RID: 18768
		Bilateral,
		// Token: 0x04004951 RID: 18769
		Fusion,
		// Token: 0x04004952 RID: 18770
		ELocalExposureMethod_MAX
	}
}
