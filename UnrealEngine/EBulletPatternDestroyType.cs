using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016D4 RID: 5844
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EBulletPatternDestroyType")]
	public enum EBulletPatternDestroyType : byte
	{
		// Token: 0x0400B83D RID: 47165
		TimeEnd,
		// Token: 0x0400B83E RID: 47166
		EmitterEmpty,
		// Token: 0x0400B83F RID: 47167
		EBulletPatternDestroyType_MAX
	}
}
