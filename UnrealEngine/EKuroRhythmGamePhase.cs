using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FB RID: 1275
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmGamePhase")]
	public enum EKuroRhythmGamePhase : byte
	{
		// Token: 0x04003278 RID: 12920
		Uninitialized,
		// Token: 0x04003279 RID: 12921
		Initializing,
		// Token: 0x0400327A RID: 12922
		LoadingChart,
		// Token: 0x0400327B RID: 12923
		Ready,
		// Token: 0x0400327C RID: 12924
		Playing,
		// Token: 0x0400327D RID: 12925
		Paused,
		// Token: 0x0400327E RID: 12926
		Finished,
		// Token: 0x0400327F RID: 12927
		Failed,
		// Token: 0x04003280 RID: 12928
		Error,
		// Token: 0x04003281 RID: 12929
		EKuroRhythmGamePhase_MAX
	}
}
