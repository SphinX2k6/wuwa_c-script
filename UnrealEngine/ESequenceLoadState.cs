using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF2 RID: 8178
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ESequenceLoadState")]
	public enum ESequenceLoadState : byte
	{
		// Token: 0x04010BF1 RID: 68593
		SLS_None,
		// Token: 0x04010BF2 RID: 68594
		SLS_Loading,
		// Token: 0x04010BF3 RID: 68595
		SLS_Loaded,
		// Token: 0x04010BF4 RID: 68596
		SLS_MAX
	}
}
