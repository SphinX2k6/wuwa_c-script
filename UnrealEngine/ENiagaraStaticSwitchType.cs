using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024CD RID: 9421
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NiagaraEditor.ENiagaraStaticSwitchType")]
	public enum ENiagaraStaticSwitchType : byte
	{
		// Token: 0x04012D32 RID: 77106
		Bool,
		// Token: 0x04012D33 RID: 77107
		Integer,
		// Token: 0x04012D34 RID: 77108
		Enum,
		// Token: 0x04012D35 RID: 77109
		ENiagaraStaticSwitchType_MAX
	}
}
