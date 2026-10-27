using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024C9 RID: 9417
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NiagaraEditor.ENiagaraClipboardFunctionInputValueMode")]
	public enum ENiagaraClipboardFunctionInputValueMode
	{
		// Token: 0x04012D16 RID: 77078
		Local,
		// Token: 0x04012D17 RID: 77079
		Linked,
		// Token: 0x04012D18 RID: 77080
		Data,
		// Token: 0x04012D19 RID: 77081
		Expression,
		// Token: 0x04012D1A RID: 77082
		Dynamic,
		// Token: 0x04012D1B RID: 77083
		ENiagaraClipboardFunctionInputValueMode_MAX
	}
}
