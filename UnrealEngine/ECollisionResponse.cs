using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001D7 RID: 471
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECollisionResponse")]
	public enum ECollisionResponse
	{
		// Token: 0x04000B93 RID: 2963
		ECR_Ignore,
		// Token: 0x04000B94 RID: 2964
		ECR_Overlap,
		// Token: 0x04000B95 RID: 2965
		ECR_Block,
		// Token: 0x04000B96 RID: 2966
		ECR_MAX
	}
}
