using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004EB RID: 1259
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EControlRigModifyBoneMode")]
	public enum EControlRigModifyBoneMode : byte
	{
		// Token: 0x04002029 RID: 8233
		OverrideLocal,
		// Token: 0x0400202A RID: 8234
		OverrideGlobal,
		// Token: 0x0400202B RID: 8235
		AdditiveLocal,
		// Token: 0x0400202C RID: 8236
		AdditiveGlobal,
		// Token: 0x0400202D RID: 8237
		Max,
		// Token: 0x0400202E RID: 8238
		EControlRigModifyBoneMode_MAX
	}
}
