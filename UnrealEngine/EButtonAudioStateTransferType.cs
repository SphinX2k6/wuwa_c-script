using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FD6 RID: 8150
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EButtonAudioStateTransferType")]
	public enum EButtonAudioStateTransferType : byte
	{
		// Token: 0x04010B32 RID: 68402
		None,
		// Token: 0x04010B33 RID: 68403
		NormalToHighLight,
		// Token: 0x04010B34 RID: 68404
		HighlightToNormal,
		// Token: 0x04010B35 RID: 68405
		HighLightToPress,
		// Token: 0x04010B36 RID: 68406
		PressToRelease,
		// Token: 0x04010B37 RID: 68407
		DisabledPress,
		// Token: 0x04010B38 RID: 68408
		EButtonAudioStateTransferType_MAX
	}
}
