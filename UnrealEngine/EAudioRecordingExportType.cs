using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009FF RID: 2559
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAudioRecordingExportType")]
	public enum EAudioRecordingExportType : byte
	{
		// Token: 0x04004498 RID: 17560
		SoundWave,
		// Token: 0x04004499 RID: 17561
		WavFile,
		// Token: 0x0400449A RID: 17562
		EAudioRecordingExportType_MAX
	}
}
