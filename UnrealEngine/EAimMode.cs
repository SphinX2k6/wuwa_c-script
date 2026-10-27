using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004E1 RID: 1249
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EAimMode")]
	public enum EAimMode : byte
	{
		// Token: 0x04001FDA RID: 8154
		AimAtTarget,
		// Token: 0x04001FDB RID: 8155
		OrientToTarget,
		// Token: 0x04001FDC RID: 8156
		MAX
	}
}
