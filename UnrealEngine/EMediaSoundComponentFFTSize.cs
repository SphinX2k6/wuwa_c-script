using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002292 RID: 8850
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MediaAssets.EMediaSoundComponentFFTSize")]
	public enum EMediaSoundComponentFFTSize : byte
	{
		// Token: 0x04011F5B RID: 73563
		Min_64,
		// Token: 0x04011F5C RID: 73564
		Small_256,
		// Token: 0x04011F5D RID: 73565
		Medium_512,
		// Token: 0x04011F5E RID: 73566
		Large_1024,
		// Token: 0x04011F5F RID: 73567
		EMediaSoundComponentFFTSize_MAX
	}
}
