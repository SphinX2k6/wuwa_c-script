using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001216 RID: 4630
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.URayTracingSupport")]
	public enum URayTracingSupport : byte
	{
		// Token: 0x040091FB RID: 37371
		Supported,
		// Token: 0x040091FC RID: 37372
		NotSupportedDxr1_1,
		// Token: 0x040091FD RID: 37373
		NotSupportedVideoMemory,
		// Token: 0x040091FE RID: 37374
		NotSupportedDevice,
		// Token: 0x040091FF RID: 37375
		URayTracingSupport_MAX
	}
}
