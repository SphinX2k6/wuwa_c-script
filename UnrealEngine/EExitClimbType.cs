using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002E8 RID: 744
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EExitClimbType")]
	public enum EExitClimbType : byte
	{
		// Token: 0x04002057 RID: 8279
		Leave,
		// Token: 0x04002058 RID: 8280
		Water,
		// Token: 0x04002059 RID: 8281
		Top,
		// Token: 0x0400205A RID: 8282
		Bottom,
		// Token: 0x0400205B RID: 8283
		Jump,
		// Token: 0x0400205C RID: 8284
		Unknown,
		// Token: 0x0400205D RID: 8285
		Sprint,
		// Token: 0x0400205E RID: 8286
		Vault,
		// Token: 0x0400205F RID: 8287
		SprintVaultFar,
		// Token: 0x04002060 RID: 8288
		SprintVaultNear,
		// Token: 0x04002061 RID: 8289
		BlockUp,
		// Token: 0x04002062 RID: 8290
		EExitClimbType_MAX
	}
}
