using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A28 RID: 2600
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EClampMode")]
	public enum EClampMode
	{
		// Token: 0x04004584 RID: 17796
		CMODE_Clamp,
		// Token: 0x04004585 RID: 17797
		CMODE_ClampMin,
		// Token: 0x04004586 RID: 17798
		CMODE_ClampMax,
		// Token: 0x04004587 RID: 17799
		CMODE_MAX
	}
}
