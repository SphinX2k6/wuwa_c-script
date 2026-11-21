using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000D2 RID: 210
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkMidiEventType")]
	public enum EAkMidiEventType : byte
	{
		// Token: 0x04000339 RID: 825
		AkMidiEventTypeInvalid,
		// Token: 0x0400033A RID: 826
		AkMidiEventTypeNoteOff = 128,
		// Token: 0x0400033B RID: 827
		AkMidiEventTypeNoteOn = 144,
		// Token: 0x0400033C RID: 828
		AkMidiEventTypeNoteAftertouch = 160,
		// Token: 0x0400033D RID: 829
		AkMidiEventTypeController = 176,
		// Token: 0x0400033E RID: 830
		AkMidiEventTypeProgramChange = 192,
		// Token: 0x0400033F RID: 831
		AkMidiEventTypeChannelAftertouch = 208,
		// Token: 0x04000340 RID: 832
		AkMidiEventTypePitchBend = 224,
		// Token: 0x04000341 RID: 833
		AkMidiEventTypeSysex = 240,
		// Token: 0x04000342 RID: 834
		AkMidiEventTypeEscape = 247,
		// Token: 0x04000343 RID: 835
		AkMidiEventTypeMeta = 255
	}
}
