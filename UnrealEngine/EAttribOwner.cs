using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200147C RID: 5244
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EAttribOwner")]
	public enum EAttribOwner : sbyte
	{
		// Token: 0x0400A40C RID: 41996
		Invalid = -1,
		// Token: 0x0400A40D RID: 41997
		Vertex,
		// Token: 0x0400A40E RID: 41998
		Point,
		// Token: 0x0400A40F RID: 41999
		Prim,
		// Token: 0x0400A410 RID: 42000
		Detail,
		// Token: 0x0400A411 RID: 42001
		EAttribOwner_MAX
	}
}
