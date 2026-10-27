using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A8F RID: 2703
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroISMCullingType")]
	public enum EKuroISMCullingType : byte
	{
		// Token: 0x04004867 RID: 18535
		None,
		// Token: 0x04004868 RID: 18536
		Near,
		// Token: 0x04004869 RID: 18537
		Middle,
		// Token: 0x0400486A RID: 18538
		Far,
		// Token: 0x0400486B RID: 18539
		SuperFar,
		// Token: 0x0400486C RID: 18540
		Impostor,
		// Token: 0x0400486D RID: 18541
		Grass,
		// Token: 0x0400486E RID: 18542
		ExtremeFar,
		// Token: 0x0400486F RID: 18543
		Pcg,
		// Token: 0x04004870 RID: 18544
		Grass3_0,
		// Token: 0x04004871 RID: 18545
		EKuroISMCullingType_MAX
	}
}
