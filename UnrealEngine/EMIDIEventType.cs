using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022E7 RID: 8935
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MIDIDevice.EMIDIEventType")]
	public enum EMIDIEventType : byte
	{
		// Token: 0x04012138 RID: 74040
		Unknown,
		// Token: 0x04012139 RID: 74041
		NoteOff = 8,
		// Token: 0x0401213A RID: 74042
		NoteOn,
		// Token: 0x0401213B RID: 74043
		NoteAfterTouch,
		// Token: 0x0401213C RID: 74044
		ControlChange,
		// Token: 0x0401213D RID: 74045
		ProgramChange,
		// Token: 0x0401213E RID: 74046
		ChannelAfterTouch,
		// Token: 0x0401213F RID: 74047
		PitchBend,
		// Token: 0x04012140 RID: 74048
		EMIDIEventType_MAX
	}
}
