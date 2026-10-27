using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A4A RID: 6730
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroTargetPlatform")]
	public enum EKuroTargetPlatform : byte
	{
		// Token: 0x0400D758 RID: 55128
		Win,
		// Token: 0x0400D759 RID: 55129
		IOS,
		// Token: 0x0400D75A RID: 55130
		Android,
		// Token: 0x0400D75B RID: 55131
		MaxTarget,
		// Token: 0x0400D75C RID: 55132
		EKuroTargetPlatform_MAX
	}
}
