using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200295B RID: 10587
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.ETickMode")]
	public enum ETickMode : byte
	{
		// Token: 0x040158A2 RID: 88226
		Disabled,
		// Token: 0x040158A3 RID: 88227
		Enabled,
		// Token: 0x040158A4 RID: 88228
		Automatic,
		// Token: 0x040158A5 RID: 88229
		ETickMode_MAX
	}
}
