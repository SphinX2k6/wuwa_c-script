using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023D0 RID: 9168
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EUpdateClockSource")]
	public enum EUpdateClockSource : byte
	{
		// Token: 0x04012682 RID: 75394
		Tick,
		// Token: 0x04012683 RID: 75395
		Platform,
		// Token: 0x04012684 RID: 75396
		Audio,
		// Token: 0x04012685 RID: 75397
		RelativeTimecode,
		// Token: 0x04012686 RID: 75398
		Timecode,
		// Token: 0x04012687 RID: 75399
		Custom,
		// Token: 0x04012688 RID: 75400
		EUpdateClockSource_MAX
	}
}
