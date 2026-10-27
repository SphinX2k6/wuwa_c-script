using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024EB RID: 9451
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraDefaultMode")]
	public enum ENiagaraDefaultMode : byte
	{
		// Token: 0x04012DE7 RID: 77287
		Value,
		// Token: 0x04012DE8 RID: 77288
		Binding,
		// Token: 0x04012DE9 RID: 77289
		Custom,
		// Token: 0x04012DEA RID: 77290
		ENiagaraDefaultMode_MAX
	}
}
