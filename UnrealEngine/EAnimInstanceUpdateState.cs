using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001CB RID: 459
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimInstanceUpdateState")]
	public enum EAnimInstanceUpdateState : byte
	{
		// Token: 0x04000B34 RID: 2868
		NotStart,
		// Token: 0x04000B35 RID: 2869
		Updating,
		// Token: 0x04000B36 RID: 2870
		Loading,
		// Token: 0x04000B37 RID: 2871
		Evaluating,
		// Token: 0x04000B38 RID: 2872
		Complete,
		// Token: 0x04000B39 RID: 2873
		EAnimInstanceUpdateState_MAX
	}
}
