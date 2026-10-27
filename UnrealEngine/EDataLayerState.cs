using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A3E RID: 2622
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDataLayerState")]
	public enum EDataLayerState : byte
	{
		// Token: 0x04004623 RID: 17955
		Unloaded,
		// Token: 0x04004624 RID: 17956
		Loaded,
		// Token: 0x04004625 RID: 17957
		Activated,
		// Token: 0x04004626 RID: 17958
		EDataLayerState_MAX
	}
}
