using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002A9 RID: 681
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.URayTracingSupport")]
	public enum URayTracingSupport : byte
	{
		// Token: 0x04001D2B RID: 7467
		Supported,
		// Token: 0x04001D2C RID: 7468
		NotSupportedDxr1_1,
		// Token: 0x04001D2D RID: 7469
		NotSupportedVideoMemory,
		// Token: 0x04001D2E RID: 7470
		NotSupportedDevice,
		// Token: 0x04001D2F RID: 7471
		URayTracingSupport_MAX
	}
}
