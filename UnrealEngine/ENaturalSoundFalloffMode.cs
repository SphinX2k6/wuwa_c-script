using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AE0 RID: 2784
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENaturalSoundFalloffMode")]
	public enum ENaturalSoundFalloffMode : byte
	{
		// Token: 0x04004B1D RID: 19229
		Continues,
		// Token: 0x04004B1E RID: 19230
		Silent,
		// Token: 0x04004B1F RID: 19231
		Hold,
		// Token: 0x04004B20 RID: 19232
		ENaturalSoundFalloffMode_MAX
	}
}
