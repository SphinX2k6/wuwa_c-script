using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002290 RID: 8848
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MediaAssets.EMediaPlayerTrack")]
	public enum EMediaPlayerTrack : byte
	{
		// Token: 0x04011F4D RID: 73549
		Audio,
		// Token: 0x04011F4E RID: 73550
		Caption,
		// Token: 0x04011F4F RID: 73551
		Metadata,
		// Token: 0x04011F50 RID: 73552
		Script,
		// Token: 0x04011F51 RID: 73553
		Subtitle,
		// Token: 0x04011F52 RID: 73554
		Text,
		// Token: 0x04011F53 RID: 73555
		Video,
		// Token: 0x04011F54 RID: 73556
		EMediaPlayerTrack_MAX
	}
}
