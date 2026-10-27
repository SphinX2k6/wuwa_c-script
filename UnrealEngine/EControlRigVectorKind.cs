using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004ED RID: 1261
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EControlRigVectorKind")]
	public enum EControlRigVectorKind : byte
	{
		// Token: 0x04002038 RID: 8248
		Direction,
		// Token: 0x04002039 RID: 8249
		Location,
		// Token: 0x0400203A RID: 8250
		EControlRigVectorKind_MAX
	}
}
