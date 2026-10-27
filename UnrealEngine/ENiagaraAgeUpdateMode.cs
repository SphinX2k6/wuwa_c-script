using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024E1 RID: 9441
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraAgeUpdateMode")]
	public enum ENiagaraAgeUpdateMode : byte
	{
		// Token: 0x04012DB4 RID: 77236
		TickDeltaTime,
		// Token: 0x04012DB5 RID: 77237
		DesiredAge,
		// Token: 0x04012DB6 RID: 77238
		DesiredAgeNoSeek,
		// Token: 0x04012DB7 RID: 77239
		ENiagaraAgeUpdateMode_MAX
	}
}
