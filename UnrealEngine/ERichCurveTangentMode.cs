using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001F6 RID: 502
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERichCurveTangentMode")]
	public enum ERichCurveTangentMode
	{
		// Token: 0x04000C7E RID: 3198
		RCTM_Auto,
		// Token: 0x04000C7F RID: 3199
		RCTM_User,
		// Token: 0x04000C80 RID: 3200
		RCTM_Break,
		// Token: 0x04000C81 RID: 3201
		RCTM_None,
		// Token: 0x04000C82 RID: 3202
		RCTM_MAX
	}
}
