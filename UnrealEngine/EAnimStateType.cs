using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000347 RID: 839
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraph.EAnimStateType")]
	public enum EAnimStateType
	{
		// Token: 0x04001413 RID: 5139
		AST_SingleAnimation,
		// Token: 0x04001414 RID: 5140
		AST_BlendGraph,
		// Token: 0x04001415 RID: 5141
		AST_MAX
	}
}
