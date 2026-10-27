using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002714 RID: 10004
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SequenceRecorder.EAudioRecordingMode")]
	public enum EAudioRecordingMode : byte
	{
		// Token: 0x04013F9C RID: 81820
		None,
		// Token: 0x04013F9D RID: 81821
		AudioTrack,
		// Token: 0x04013F9E RID: 81822
		EAudioRecordingMode_MAX
	}
}
