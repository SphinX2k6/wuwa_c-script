using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200174C RID: 5964
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.EAnimPerfTestActorsGenMethod")]
	public enum EAnimPerfTestActorsGenMethod : sbyte
	{
		// Token: 0x0400BB25 RID: 47909
		GenFromTemplate,
		// Token: 0x0400BB26 RID: 47910
		GenRandomly,
		// Token: 0x0400BB27 RID: 47911
		GenAll,
		// Token: 0x0400BB28 RID: 47912
		EAnimPerfTestActorsGenMethod_MAX
	}
}
