using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B4A RID: 2890
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERichCurveTangentMode")]
	public enum ERichCurveTangentMode
	{
		// Token: 0x04004F98 RID: 20376
		RCTM_Auto,
		// Token: 0x04004F99 RID: 20377
		RCTM_User,
		// Token: 0x04004F9A RID: 20378
		RCTM_Break,
		// Token: 0x04004F9B RID: 20379
		RCTM_None,
		// Token: 0x04004F9C RID: 20380
		RCTM_MAX
	}
}
