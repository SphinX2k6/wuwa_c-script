using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000D4 RID: 212
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.ERTPCValueType")]
	public enum ERTPCValueType : byte
	{
		// Token: 0x0400034A RID: 842
		Default,
		// Token: 0x0400034B RID: 843
		Global,
		// Token: 0x0400034C RID: 844
		GameObject,
		// Token: 0x0400034D RID: 845
		PlayingID,
		// Token: 0x0400034E RID: 846
		Unavailable,
		// Token: 0x0400034F RID: 847
		ERTPCValueType_MAX
	}
}
