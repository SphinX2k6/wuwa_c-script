using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000717 RID: 1815
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.ELocalizedTextSourceCategory")]
	public enum ELocalizedTextSourceCategory : byte
	{
		// Token: 0x04002DEE RID: 11758
		Game,
		// Token: 0x04002DEF RID: 11759
		Engine,
		// Token: 0x04002DF0 RID: 11760
		Editor,
		// Token: 0x04002DF1 RID: 11761
		ELocalizedTextSourceCategory_MAX
	}
}
