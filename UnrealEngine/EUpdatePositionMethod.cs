using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000778 RID: 1912
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EUpdatePositionMethod")]
	public enum EUpdatePositionMethod : byte
	{
		// Token: 0x040046BB RID: 18107
		Play,
		// Token: 0x040046BC RID: 18108
		Jump,
		// Token: 0x040046BD RID: 18109
		Scrub,
		// Token: 0x040046BE RID: 18110
		EUpdatePositionMethod_MAX
	}
}
