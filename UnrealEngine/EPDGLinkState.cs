using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200149C RID: 5276
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EPDGLinkState")]
	public enum EPDGLinkState : byte
	{
		// Token: 0x0400A504 RID: 42244
		Inactive,
		// Token: 0x0400A505 RID: 42245
		Linking,
		// Token: 0x0400A506 RID: 42246
		Linked,
		// Token: 0x0400A507 RID: 42247
		Error_Not_Linked,
		// Token: 0x0400A508 RID: 42248
		EPDGLinkState_MAX
	}
}
