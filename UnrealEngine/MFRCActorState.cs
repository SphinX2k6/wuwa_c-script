using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022E6 RID: 8934
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MFRCModule.MFRCActorState")]
	public enum MFRCActorState : byte
	{
		// Token: 0x04012130 RID: 74032
		NONE,
		// Token: 0x04012131 RID: 74033
		INIT,
		// Token: 0x04012132 RID: 74034
		READY,
		// Token: 0x04012133 RID: 74035
		START,
		// Token: 0x04012134 RID: 74036
		STOP,
		// Token: 0x04012135 RID: 74037
		SHUTDOWN,
		// Token: 0x04012136 RID: 74038
		MFRCActorState_MAX
	}
}
