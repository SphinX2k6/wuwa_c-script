using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF5 RID: 8181
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EStateTransitionType")]
	public enum EStateTransitionType : byte
	{
		// Token: 0x04010C05 RID: 68613
		ImmediateSet,
		// Token: 0x04010C06 RID: 68614
		Gradually,
		// Token: 0x04010C07 RID: 68615
		EStateTransitionType_MAX
	}
}
