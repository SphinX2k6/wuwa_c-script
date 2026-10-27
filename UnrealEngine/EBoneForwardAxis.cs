using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015CD RID: 5581
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KawaiiPhysics.EBoneForwardAxis")]
	public enum EBoneForwardAxis : byte
	{
		// Token: 0x0400AF26 RID: 44838
		X_Positive,
		// Token: 0x0400AF27 RID: 44839
		X_Negative,
		// Token: 0x0400AF28 RID: 44840
		Y_Positive,
		// Token: 0x0400AF29 RID: 44841
		Y_Negative,
		// Token: 0x0400AF2A RID: 44842
		Z_Positive,
		// Token: 0x0400AF2B RID: 44843
		Z_Negative,
		// Token: 0x0400AF2C RID: 44844
		EBoneForwardAxis_MAX
	}
}
