using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019DA RID: 6618
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EKDMDrawDebugType")]
	public enum EKDMDrawDebugType : byte
	{
		// Token: 0x0400D476 RID: 54390
		OPEN,
		// Token: 0x0400D477 RID: 54391
		CLOSE,
		// Token: 0x0400D478 RID: 54392
		STOP,
		// Token: 0x0400D479 RID: 54393
		EKDMDrawDebugType_MAX
	}
}
