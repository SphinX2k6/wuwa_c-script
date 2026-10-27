using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200027A RID: 634
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkMidiEventType")]
	public enum EAkMidiEventType : byte
	{
		// Token: 0x04000D73 RID: 3443
		AkMidiEventTypeInvalid,
		// Token: 0x04000D74 RID: 3444
		AkMidiEventTypeNoteOff = 128,
		// Token: 0x04000D75 RID: 3445
		AkMidiEventTypeNoteOn = 144,
		// Token: 0x04000D76 RID: 3446
		AkMidiEventTypeNoteAftertouch = 160,
		// Token: 0x04000D77 RID: 3447
		AkMidiEventTypeController = 176,
		// Token: 0x04000D78 RID: 3448
		AkMidiEventTypeProgramChange = 192,
		// Token: 0x04000D79 RID: 3449
		AkMidiEventTypeChannelAftertouch = 208,
		// Token: 0x04000D7A RID: 3450
		AkMidiEventTypePitchBend = 224,
		// Token: 0x04000D7B RID: 3451
		AkMidiEventTypeSysex = 240,
		// Token: 0x04000D7C RID: 3452
		AkMidiEventTypeEscape = 247,
		// Token: 0x04000D7D RID: 3453
		AkMidiEventTypeMeta = 255
	}
}
