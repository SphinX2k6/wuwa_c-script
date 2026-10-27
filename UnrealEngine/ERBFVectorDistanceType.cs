using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F5 RID: 1269
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERBFVectorDistanceType")]
	public enum ERBFVectorDistanceType : byte
	{
		// Token: 0x04002060 RID: 8288
		Euclidean,
		// Token: 0x04002061 RID: 8289
		Manhattan,
		// Token: 0x04002062 RID: 8290
		ArcLength,
		// Token: 0x04002063 RID: 8291
		ERBFVectorDistanceType_MAX
	}
}
