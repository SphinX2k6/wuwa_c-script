using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BC3 RID: 3011
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWorldPositionIncludedOffsets")]
	public enum EWorldPositionIncludedOffsets
	{
		// Token: 0x040052D9 RID: 21209
		WPT_Default,
		// Token: 0x040052DA RID: 21210
		WPT_ExcludeAllShaderOffsets,
		// Token: 0x040052DB RID: 21211
		WPT_CameraRelative,
		// Token: 0x040052DC RID: 21212
		WPT_CameraRelativeNoOffsets,
		// Token: 0x040052DD RID: 21213
		WPT_MAX
	}
}
