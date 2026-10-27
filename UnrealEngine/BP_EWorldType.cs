using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A52 RID: 6738
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.BP_EWorldType")]
	public enum BP_EWorldType : byte
	{
		// Token: 0x0400D78F RID: 55183
		None,
		// Token: 0x0400D790 RID: 55184
		Game,
		// Token: 0x0400D791 RID: 55185
		Editor,
		// Token: 0x0400D792 RID: 55186
		PIE,
		// Token: 0x0400D793 RID: 55187
		EditorPreview,
		// Token: 0x0400D794 RID: 55188
		GamePreview,
		// Token: 0x0400D795 RID: 55189
		GameRPC,
		// Token: 0x0400D796 RID: 55190
		Inactive,
		// Token: 0x0400D797 RID: 55191
		BP_MAX
	}
}
