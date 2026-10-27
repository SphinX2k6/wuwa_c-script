using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B67 RID: 2919
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESkyLightSourceType")]
	public enum ESkyLightSourceType
	{
		// Token: 0x04005067 RID: 20583
		SLS_CapturedScene,
		// Token: 0x04005068 RID: 20584
		SLS_SpecifiedCubemap,
		// Token: 0x04005069 RID: 20585
		SLS_MAX
	}
}
