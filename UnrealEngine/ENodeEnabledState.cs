using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AF9 RID: 2809
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENodeEnabledState")]
	public enum ENodeEnabledState : byte
	{
		// Token: 0x04004CF2 RID: 19698
		Enabled,
		// Token: 0x04004CF3 RID: 19699
		Disabled,
		// Token: 0x04004CF4 RID: 19700
		DevelopmentOnly,
		// Token: 0x04004CF5 RID: 19701
		ENodeEnabledState_MAX
	}
}
