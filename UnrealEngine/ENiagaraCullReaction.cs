using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024E3 RID: 9443
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraCullReaction")]
	public enum ENiagaraCullReaction
	{
		// Token: 0x04012DC1 RID: 77249
		Deactivate,
		// Token: 0x04012DC2 RID: 77250
		DeactivateImmediate,
		// Token: 0x04012DC3 RID: 77251
		DeactivateResume,
		// Token: 0x04012DC4 RID: 77252
		DeactivateImmediateResume,
		// Token: 0x04012DC5 RID: 77253
		ENiagaraCullReaction_MAX
	}
}
