using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000319 RID: 793
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EDrivenDestinationMode")]
	public enum EDrivenDestinationMode : byte
	{
		// Token: 0x040012EE RID: 4846
		Bone,
		// Token: 0x040012EF RID: 4847
		MorphTarget,
		// Token: 0x040012F0 RID: 4848
		MaterialParameter,
		// Token: 0x040012F1 RID: 4849
		EDrivenDestinationMode_MAX
	}
}
