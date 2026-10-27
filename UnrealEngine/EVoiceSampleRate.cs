using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB8 RID: 3000
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVoiceSampleRate")]
	public enum EVoiceSampleRate
	{
		// Token: 0x040052A4 RID: 21156
		Low16000Hz = 16000,
		// Token: 0x040052A5 RID: 21157
		Normal24000Hz = 24000,
		// Token: 0x040052A6 RID: 21158
		EVoiceSampleRate_MAX
	}
}
