using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BBE RID: 3006
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWorldPartitionCVarProjectDefaultOverride")]
	public enum EWorldPartitionCVarProjectDefaultOverride : byte
	{
		// Token: 0x040052C1 RID: 21185
		ProjectDefault,
		// Token: 0x040052C2 RID: 21186
		Disabled,
		// Token: 0x040052C3 RID: 21187
		Enabled,
		// Token: 0x040052C4 RID: 21188
		EWorldPartitionCVarProjectDefaultOverride_MAX
	}
}
