using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F1 RID: 9457
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraMeshLockedAxisSpace")]
	public enum ENiagaraMeshLockedAxisSpace : byte
	{
		// Token: 0x04012E09 RID: 77321
		Simulation,
		// Token: 0x04012E0A RID: 77322
		World,
		// Token: 0x04012E0B RID: 77323
		Local,
		// Token: 0x04012E0C RID: 77324
		ENiagaraMeshLockedAxisSpace_MAX
	}
}
