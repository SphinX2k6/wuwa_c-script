using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200177A RID: 6010
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EJacobiChainVertexMode")]
	public enum EJacobiChainVertexMode : byte
	{
		// Token: 0x0400BCD1 RID: 48337
		Unassigned,
		// Token: 0x0400BCD2 RID: 48338
		Soft,
		// Token: 0x0400BCD3 RID: 48339
		Rigid,
		// Token: 0x0400BCD4 RID: 48340
		EJacobiChainVertexMode_MAX
	}
}
