using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002305 RID: 8965
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieSceneCapture.EMovieSceneCaptureProtocolState")]
	public enum EMovieSceneCaptureProtocolState : byte
	{
		// Token: 0x040121DE RID: 74206
		Idle,
		// Token: 0x040121DF RID: 74207
		Initialized,
		// Token: 0x040121E0 RID: 74208
		Capturing,
		// Token: 0x040121E1 RID: 74209
		Finalizing,
		// Token: 0x040121E2 RID: 74210
		EMovieSceneCaptureProtocolState_MAX
	}
}
