using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001492 RID: 5266
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniPCGToolType")]
	public enum EHoudiniPCGToolType : byte
	{
		// Token: 0x0400A4CC RID: 42188
		Default,
		// Token: 0x0400A4CD RID: 42189
		Customized_BoundSelectorByFolder,
		// Token: 0x0400A4CE RID: 42190
		EHoudiniPCGToolType_MAX
	}
}
