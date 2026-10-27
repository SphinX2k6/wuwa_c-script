using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B94 RID: 2964
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EToonLightType")]
	public enum EToonLightType
	{
		// Token: 0x04005192 RID: 20882
		ToonLightType_Effect,
		// Token: 0x04005193 RID: 20883
		ToonLightType_LevelSequence,
		// Token: 0x04005194 RID: 20884
		ToonLightType_Scene,
		// Token: 0x04005195 RID: 20885
		ToonLightType_MAX
	}
}
