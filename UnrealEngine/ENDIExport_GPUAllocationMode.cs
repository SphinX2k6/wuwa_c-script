using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024DD RID: 9437
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENDIExport_GPUAllocationMode")]
	public enum ENDIExport_GPUAllocationMode : byte
	{
		// Token: 0x04012DA0 RID: 77216
		FixedSize,
		// Token: 0x04012DA1 RID: 77217
		PerParticle,
		// Token: 0x04012DA2 RID: 77218
		ENDIExport_MAX
	}
}
