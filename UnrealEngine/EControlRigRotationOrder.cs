using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004EC RID: 1260
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EControlRigRotationOrder")]
	public enum EControlRigRotationOrder : byte
	{
		// Token: 0x04002030 RID: 8240
		XYZ,
		// Token: 0x04002031 RID: 8241
		XZY,
		// Token: 0x04002032 RID: 8242
		YXZ,
		// Token: 0x04002033 RID: 8243
		YZX,
		// Token: 0x04002034 RID: 8244
		ZXY,
		// Token: 0x04002035 RID: 8245
		ZYX,
		// Token: 0x04002036 RID: 8246
		EControlRigRotationOrder_MAX
	}
}
