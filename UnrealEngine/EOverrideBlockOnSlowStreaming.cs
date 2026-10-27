using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B05 RID: 2821
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EOverrideBlockOnSlowStreaming")]
	public enum EOverrideBlockOnSlowStreaming : byte
	{
		// Token: 0x04004D4C RID: 19788
		NoOverride,
		// Token: 0x04004D4D RID: 19789
		Blocking,
		// Token: 0x04004D4E RID: 19790
		NotBlocking,
		// Token: 0x04004D4F RID: 19791
		EOverrideBlockOnSlowStreaming_MAX
	}
}
