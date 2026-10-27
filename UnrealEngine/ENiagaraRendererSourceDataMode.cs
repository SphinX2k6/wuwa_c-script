using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F9 RID: 9465
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraRendererSourceDataMode")]
	public enum ENiagaraRendererSourceDataMode : byte
	{
		// Token: 0x04012E3C RID: 77372
		Particles,
		// Token: 0x04012E3D RID: 77373
		Emitter,
		// Token: 0x04012E3E RID: 77374
		ENiagaraRendererSourceDataMode_MAX
	}
}
