using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A02 RID: 2562
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAudioVolumeLocationState")]
	public enum EAudioVolumeLocationState : byte
	{
		// Token: 0x040044A7 RID: 17575
		InsideTheVolume,
		// Token: 0x040044A8 RID: 17576
		OutsideTheVolume,
		// Token: 0x040044A9 RID: 17577
		EAudioVolumeLocationState_MAX
	}
}
