using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022A7 RID: 8871
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MediaCompositingEditor.EMediaPlayerRecordingNumerationStyle")]
	public enum EMediaPlayerRecordingNumerationStyle : byte
	{
		// Token: 0x04011FEC RID: 73708
		AppendFrameNumber,
		// Token: 0x04011FED RID: 73709
		AppendSampleTime,
		// Token: 0x04011FEE RID: 73710
		EMediaPlayerRecordingNumerationStyle_MAX
	}
}
