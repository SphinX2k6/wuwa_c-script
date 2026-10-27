using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FB RID: 1275
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigEvent")]
	public enum ERigEvent : byte
	{
		// Token: 0x04002088 RID: 8328
		None,
		// Token: 0x04002089 RID: 8329
		RequestAutoKey,
		// Token: 0x0400208A RID: 8330
		Max,
		// Token: 0x0400208B RID: 8331
		ERigEvent_MAX
	}
}
