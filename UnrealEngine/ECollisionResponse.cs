using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A2E RID: 2606
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECollisionResponse")]
	public enum ECollisionResponse
	{
		// Token: 0x040045C1 RID: 17857
		ECR_Ignore,
		// Token: 0x040045C2 RID: 17858
		ECR_Overlap,
		// Token: 0x040045C3 RID: 17859
		ECR_Block,
		// Token: 0x040045C4 RID: 17860
		ECR_MAX
	}
}
