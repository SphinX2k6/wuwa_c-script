using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000649 RID: 1609
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EButtonAudioStateTransferType")]
	public enum EButtonAudioStateTransferType : byte
	{
		// Token: 0x04003D99 RID: 15769
		None,
		// Token: 0x04003D9A RID: 15770
		NormalToHighLight,
		// Token: 0x04003D9B RID: 15771
		HighlightToNormal,
		// Token: 0x04003D9C RID: 15772
		HighLightToPress,
		// Token: 0x04003D9D RID: 15773
		PressToRelease,
		// Token: 0x04003D9E RID: 15774
		DisabledPress,
		// Token: 0x04003D9F RID: 15775
		EButtonAudioStateTransferType_MAX
	}
}
