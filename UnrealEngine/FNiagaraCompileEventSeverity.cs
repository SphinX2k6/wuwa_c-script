using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024CE RID: 9422
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NiagaraShader.FNiagaraCompileEventSeverity")]
	public enum FNiagaraCompileEventSeverity : byte
	{
		// Token: 0x04012D37 RID: 77111
		Log,
		// Token: 0x04012D38 RID: 77112
		Warning,
		// Token: 0x04012D39 RID: 77113
		Error,
		// Token: 0x04012D3A RID: 77114
		FNiagaraCompileEventSeverity_MAX
	}
}
