using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C41 RID: 7233
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmGamePhase")]
	public enum EKuroRhythmGamePhase : byte
	{
		// Token: 0x0400F121 RID: 61729
		Uninitialized,
		// Token: 0x0400F122 RID: 61730
		Initializing,
		// Token: 0x0400F123 RID: 61731
		LoadingChart,
		// Token: 0x0400F124 RID: 61732
		Ready,
		// Token: 0x0400F125 RID: 61733
		Playing,
		// Token: 0x0400F126 RID: 61734
		Paused,
		// Token: 0x0400F127 RID: 61735
		Finished,
		// Token: 0x0400F128 RID: 61736
		Failed,
		// Token: 0x0400F129 RID: 61737
		Error,
		// Token: 0x0400F12A RID: 61738
		EKuroRhythmGamePhase_MAX
	}
}
