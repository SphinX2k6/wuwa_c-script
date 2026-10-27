using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F2 RID: 9458
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraMeshLODMode")]
	public enum ENiagaraMeshLODMode : byte
	{
		// Token: 0x04012E0E RID: 77326
		LODLevel,
		// Token: 0x04012E0F RID: 77327
		ByComponentBounds,
		// Token: 0x04012E10 RID: 77328
		ENiagaraMeshLODMode_MAX
	}
}
