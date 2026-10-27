using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023CB RID: 9163
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieScenePlayerStatus")]
	public enum EMovieScenePlayerStatus
	{
		// Token: 0x04012664 RID: 75364
		Stopped,
		// Token: 0x04012665 RID: 75365
		Playing,
		// Token: 0x04012666 RID: 75366
		Recording,
		// Token: 0x04012667 RID: 75367
		Scrubbing,
		// Token: 0x04012668 RID: 75368
		Jumping,
		// Token: 0x04012669 RID: 75369
		Stepping,
		// Token: 0x0401266A RID: 75370
		Paused,
		// Token: 0x0401266B RID: 75371
		MAX
	}
}
