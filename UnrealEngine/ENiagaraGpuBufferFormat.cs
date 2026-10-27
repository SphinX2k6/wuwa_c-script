using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024EC RID: 9452
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraGpuBufferFormat")]
	public enum ENiagaraGpuBufferFormat : byte
	{
		// Token: 0x04012DEC RID: 77292
		Float,
		// Token: 0x04012DED RID: 77293
		HalfFloat,
		// Token: 0x04012DEE RID: 77294
		UnsignedNormalizedByte,
		// Token: 0x04012DEF RID: 77295
		Max,
		// Token: 0x04012DF0 RID: 77296
		ENiagaraGpuBufferFormat_MAX
	}
}
