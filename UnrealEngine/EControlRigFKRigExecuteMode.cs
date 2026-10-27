using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004EA RID: 1258
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EControlRigFKRigExecuteMode")]
	public enum EControlRigFKRigExecuteMode : byte
	{
		// Token: 0x04002024 RID: 8228
		Replace,
		// Token: 0x04002025 RID: 8229
		Additive,
		// Token: 0x04002026 RID: 8230
		Max,
		// Token: 0x04002027 RID: 8231
		EControlRigFKRigExecuteMode_MAX
	}
}
