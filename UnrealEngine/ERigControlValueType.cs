using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F9 RID: 1273
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigControlValueType")]
	public enum ERigControlValueType : byte
	{
		// Token: 0x0400207A RID: 8314
		Initial,
		// Token: 0x0400207B RID: 8315
		Current,
		// Token: 0x0400207C RID: 8316
		Minimum,
		// Token: 0x0400207D RID: 8317
		Maximum,
		// Token: 0x0400207E RID: 8318
		ERigControlValueType_MAX
	}
}
