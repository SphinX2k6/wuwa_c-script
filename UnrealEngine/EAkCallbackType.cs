using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000D0 RID: 208
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkCallbackType")]
	public enum EAkCallbackType : byte
	{
		// Token: 0x0400031B RID: 795
		EndOfEvent,
		// Token: 0x0400031C RID: 796
		Marker = 2,
		// Token: 0x0400031D RID: 797
		Duration,
		// Token: 0x0400031E RID: 798
		Starvation = 5,
		// Token: 0x0400031F RID: 799
		MusicPlayStarted = 7,
		// Token: 0x04000320 RID: 800
		MusicSyncBeat,
		// Token: 0x04000321 RID: 801
		MusicSyncBar,
		// Token: 0x04000322 RID: 802
		MusicSyncEntry,
		// Token: 0x04000323 RID: 803
		MusicSyncExit,
		// Token: 0x04000324 RID: 804
		MusicSyncGrid,
		// Token: 0x04000325 RID: 805
		MusicSyncUserCue,
		// Token: 0x04000326 RID: 806
		MusicSyncPoint,
		// Token: 0x04000327 RID: 807
		MIDIEvent,
		// Token: 0x04000328 RID: 808
		Reserved,
		// Token: 0x04000329 RID: 809
		Last,
		// Token: 0x0400032A RID: 810
		EAkCallbackType_MAX
	}
}
