using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A89 RID: 2697
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EInterpTrackMoveRotMode")]
	public enum EInterpTrackMoveRotMode
	{
		// Token: 0x04004848 RID: 18504
		IMR_Keyframed,
		// Token: 0x04004849 RID: 18505
		IMR_LookAtGroup,
		// Token: 0x0400484A RID: 18506
		IMR_Ignore,
		// Token: 0x0400484B RID: 18507
		IMR_MAX
	}
}
