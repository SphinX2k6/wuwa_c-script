using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FE RID: 1278
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigSpaceType")]
	public enum ERigSpaceType : byte
	{
		// Token: 0x04002099 RID: 8345
		Global,
		// Token: 0x0400209A RID: 8346
		Bone,
		// Token: 0x0400209B RID: 8347
		Control,
		// Token: 0x0400209C RID: 8348
		Space,
		// Token: 0x0400209D RID: 8349
		ERigSpaceType_MAX
	}
}
