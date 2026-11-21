using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000FF RID: 255
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.ELocalizedTextSourceCategory")]
	public enum ELocalizedTextSourceCategory : byte
	{
		// Token: 0x0400045E RID: 1118
		Game,
		// Token: 0x0400045F RID: 1119
		Engine,
		// Token: 0x04000460 RID: 1120
		Editor,
		// Token: 0x04000461 RID: 1121
		ELocalizedTextSourceCategory_MAX
	}
}
