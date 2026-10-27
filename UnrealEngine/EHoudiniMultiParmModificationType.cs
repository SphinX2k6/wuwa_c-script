using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200148D RID: 5261
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniMultiParmModificationType")]
	public enum EHoudiniMultiParmModificationType : byte
	{
		// Token: 0x0400A498 RID: 42136
		None,
		// Token: 0x0400A499 RID: 42137
		Inserted,
		// Token: 0x0400A49A RID: 42138
		Removed,
		// Token: 0x0400A49B RID: 42139
		Modified,
		// Token: 0x0400A49C RID: 42140
		EHoudiniMultiParmModificationType_MAX
	}
}
