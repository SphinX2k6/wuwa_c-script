using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FC RID: 1276
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigExecutionType")]
	public enum ERigExecutionType : byte
	{
		// Token: 0x0400208D RID: 8333
		Runtime,
		// Token: 0x0400208E RID: 8334
		Editing,
		// Token: 0x0400208F RID: 8335
		Max,
		// Token: 0x04002090 RID: 8336
		ERigExecutionType_MAX
	}
}
