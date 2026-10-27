using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200147E RID: 5246
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniAssetState")]
	public enum EHoudiniAssetState : byte
	{
		// Token: 0x0400A41B RID: 42011
		NeedInstantiation,
		// Token: 0x0400A41C RID: 42012
		NewHDA,
		// Token: 0x0400A41D RID: 42013
		PreInstantiation,
		// Token: 0x0400A41E RID: 42014
		Instantiating,
		// Token: 0x0400A41F RID: 42015
		PreCook,
		// Token: 0x0400A420 RID: 42016
		Cooking,
		// Token: 0x0400A421 RID: 42017
		PostCook,
		// Token: 0x0400A422 RID: 42018
		PreProcess,
		// Token: 0x0400A423 RID: 42019
		Processing,
		// Token: 0x0400A424 RID: 42020
		None,
		// Token: 0x0400A425 RID: 42021
		NeedRebuild,
		// Token: 0x0400A426 RID: 42022
		NeedDelete,
		// Token: 0x0400A427 RID: 42023
		Deleting,
		// Token: 0x0400A428 RID: 42024
		ProcessTemplate,
		// Token: 0x0400A429 RID: 42025
		EHoudiniAssetState_MAX
	}
}
