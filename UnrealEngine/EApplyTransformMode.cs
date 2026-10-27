using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004E2 RID: 1250
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EApplyTransformMode")]
	public enum EApplyTransformMode : byte
	{
		// Token: 0x04001FDE RID: 8158
		Override,
		// Token: 0x04001FDF RID: 8159
		Additive,
		// Token: 0x04001FE0 RID: 8160
		Max,
		// Token: 0x04001FE1 RID: 8161
		EApplyTransformMode_MAX
	}
}
