using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015AE RID: 5550
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/JsEnv.EV8GCType")]
	public enum EV8GCType : byte
	{
		// Token: 0x0400AE4B RID: 44619
		DoNothing,
		// Token: 0x0400AE4C RID: 44620
		CallV8LowMemory,
		// Token: 0x0400AE4D RID: 44621
		CallMinorGC,
		// Token: 0x0400AE4E RID: 44622
		CallFullGC,
		// Token: 0x0400AE4F RID: 44623
		CallMemoryPressureNone,
		// Token: 0x0400AE50 RID: 44624
		CallMemoryPressureModerate,
		// Token: 0x0400AE51 RID: 44625
		CallMemoryPressureCritical,
		// Token: 0x0400AE52 RID: 44626
		EV8GCType_MAX
	}
}
