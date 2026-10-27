using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028CF RID: 10447
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineReflexBlueprint.EStreamlineReflexMode")]
	public enum EStreamlineReflexMode : byte
	{
		// Token: 0x0401547B RID: 87163
		Off,
		// Token: 0x0401547C RID: 87164
		Enabled,
		// Token: 0x0401547D RID: 87165
		Boost = 3,
		// Token: 0x0401547E RID: 87166
		EStreamlineReflexMode_MAX
	}
}
