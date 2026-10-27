using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000270 RID: 624
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkCallbackType")]
	public enum EAkCallbackType : byte
	{
		// Token: 0x04000CAE RID: 3246
		EndOfEvent,
		// Token: 0x04000CAF RID: 3247
		Marker = 2,
		// Token: 0x04000CB0 RID: 3248
		Duration,
		// Token: 0x04000CB1 RID: 3249
		Starvation = 5,
		// Token: 0x04000CB2 RID: 3250
		MusicPlayStarted = 7,
		// Token: 0x04000CB3 RID: 3251
		MusicSyncBeat,
		// Token: 0x04000CB4 RID: 3252
		MusicSyncBar,
		// Token: 0x04000CB5 RID: 3253
		MusicSyncEntry,
		// Token: 0x04000CB6 RID: 3254
		MusicSyncExit,
		// Token: 0x04000CB7 RID: 3255
		MusicSyncGrid,
		// Token: 0x04000CB8 RID: 3256
		MusicSyncUserCue,
		// Token: 0x04000CB9 RID: 3257
		MusicSyncPoint,
		// Token: 0x04000CBA RID: 3258
		MIDIEvent,
		// Token: 0x04000CBB RID: 3259
		Reserved,
		// Token: 0x04000CBC RID: 3260
		Last,
		// Token: 0x04000CBD RID: 3261
		EAkCallbackType_MAX
	}
}
