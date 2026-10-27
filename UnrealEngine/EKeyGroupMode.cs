using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002718 RID: 10008
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sequencer.EKeyGroupMode")]
	public enum EKeyGroupMode : byte
	{
		// Token: 0x04013FAF RID: 81839
		KeyChanged,
		// Token: 0x04013FB0 RID: 81840
		KeyGroup,
		// Token: 0x04013FB1 RID: 81841
		KeyAll,
		// Token: 0x04013FB2 RID: 81842
		EKeyGroupMode_MAX
	}
}
