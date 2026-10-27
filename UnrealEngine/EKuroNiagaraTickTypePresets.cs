using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024DA RID: 9434
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.EKuroNiagaraTickTypePresets")]
	public enum EKuroNiagaraTickTypePresets : byte
	{
		// Token: 0x04012D90 RID: 77200
		Normal,
		// Token: 0x04012D91 RID: 77201
		Slow,
		// Token: 0x04012D92 RID: 77202
		Fast,
		// Token: 0x04012D93 RID: 77203
		Important,
		// Token: 0x04012D94 RID: 77204
		TickTypePresetsCount,
		// Token: 0x04012D95 RID: 77205
		EKuroNiagaraTickTypePresets_MAX
	}
}
