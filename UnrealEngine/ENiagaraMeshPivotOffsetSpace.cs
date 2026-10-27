using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F3 RID: 9459
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraMeshPivotOffsetSpace")]
	public enum ENiagaraMeshPivotOffsetSpace : byte
	{
		// Token: 0x04012E12 RID: 77330
		Mesh,
		// Token: 0x04012E13 RID: 77331
		Simulation,
		// Token: 0x04012E14 RID: 77332
		World,
		// Token: 0x04012E15 RID: 77333
		Local,
		// Token: 0x04012E16 RID: 77334
		ENiagaraMeshPivotOffsetSpace_MAX
	}
}
