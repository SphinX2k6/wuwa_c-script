using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A2F RID: 2607
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EComponentCreationMethod")]
	public enum EComponentCreationMethod : byte
	{
		// Token: 0x040045C6 RID: 17862
		Native,
		// Token: 0x040045C7 RID: 17863
		SimpleConstructionScript,
		// Token: 0x040045C8 RID: 17864
		UserConstructionScript,
		// Token: 0x040045C9 RID: 17865
		Instance,
		// Token: 0x040045CA RID: 17866
		EComponentCreationMethod_MAX
	}
}
