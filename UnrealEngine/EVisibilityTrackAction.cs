using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB6 RID: 2998
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVisibilityTrackAction")]
	public enum EVisibilityTrackAction
	{
		// Token: 0x0400529A RID: 21146
		EVTA_Hide,
		// Token: 0x0400529B RID: 21147
		EVTA_Show,
		// Token: 0x0400529C RID: 21148
		EVTA_Toggle,
		// Token: 0x0400529D RID: 21149
		EVTA_MAX
	}
}
