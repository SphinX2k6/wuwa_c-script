using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200163E RID: 5694
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EExitClimbType")]
	public enum EExitClimbType : byte
	{
		// Token: 0x0400B337 RID: 45879
		Leave,
		// Token: 0x0400B338 RID: 45880
		Water,
		// Token: 0x0400B339 RID: 45881
		Top,
		// Token: 0x0400B33A RID: 45882
		Bottom,
		// Token: 0x0400B33B RID: 45883
		Jump,
		// Token: 0x0400B33C RID: 45884
		Unknown,
		// Token: 0x0400B33D RID: 45885
		Sprint,
		// Token: 0x0400B33E RID: 45886
		Vault,
		// Token: 0x0400B33F RID: 45887
		SprintVaultFar,
		// Token: 0x0400B340 RID: 45888
		SprintVaultNear,
		// Token: 0x0400B341 RID: 45889
		BlockUp,
		// Token: 0x0400B342 RID: 45890
		EExitClimbType_MAX
	}
}
