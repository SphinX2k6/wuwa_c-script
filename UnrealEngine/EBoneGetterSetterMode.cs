using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004E3 RID: 1251
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EBoneGetterSetterMode")]
	public enum EBoneGetterSetterMode : byte
	{
		// Token: 0x04001FE3 RID: 8163
		LocalSpace,
		// Token: 0x04001FE4 RID: 8164
		GlobalSpace,
		// Token: 0x04001FE5 RID: 8165
		Max,
		// Token: 0x04001FE6 RID: 8166
		EBoneGetterSetterMode_MAX
	}
}
