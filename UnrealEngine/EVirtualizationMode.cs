using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB3 RID: 2995
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVirtualizationMode")]
	public enum EVirtualizationMode : byte
	{
		// Token: 0x04005289 RID: 21129
		Disabled,
		// Token: 0x0400528A RID: 21130
		PlayWhenSilent,
		// Token: 0x0400528B RID: 21131
		Restart,
		// Token: 0x0400528C RID: 21132
		EVirtualizationMode_MAX
	}
}
