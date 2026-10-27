using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ADC RID: 2780
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMouseCaptureMode")]
	public enum EMouseCaptureMode : byte
	{
		// Token: 0x04004B01 RID: 19201
		NoCapture,
		// Token: 0x04004B02 RID: 19202
		CapturePermanently,
		// Token: 0x04004B03 RID: 19203
		CapturePermanently_IncludingInitialMouseDown,
		// Token: 0x04004B04 RID: 19204
		CaptureDuringMouseDown,
		// Token: 0x04004B05 RID: 19205
		CaptureDuringRightMouseDown,
		// Token: 0x04004B06 RID: 19206
		EMouseCaptureMode_MAX
	}
}
