using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FA RID: 1274
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigElementType")]
	public enum ERigElementType : byte
	{
		// Token: 0x04002080 RID: 8320
		None,
		// Token: 0x04002081 RID: 8321
		Bone,
		// Token: 0x04002082 RID: 8322
		Space,
		// Token: 0x04002083 RID: 8323
		Control = 4,
		// Token: 0x04002084 RID: 8324
		Curve = 8,
		// Token: 0x04002085 RID: 8325
		All = 15,
		// Token: 0x04002086 RID: 8326
		ERigElementType_MAX
	}
}
