using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F7 RID: 9463
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraParameterScope")]
	public enum ENiagaraParameterScope : uint
	{
		// Token: 0x04012E26 RID: 77350
		Input,
		// Token: 0x04012E27 RID: 77351
		User,
		// Token: 0x04012E28 RID: 77352
		Engine,
		// Token: 0x04012E29 RID: 77353
		Owner,
		// Token: 0x04012E2A RID: 77354
		System,
		// Token: 0x04012E2B RID: 77355
		Emitter,
		// Token: 0x04012E2C RID: 77356
		Particles,
		// Token: 0x04012E2D RID: 77357
		ScriptPersistent,
		// Token: 0x04012E2E RID: 77358
		ScriptTransient,
		// Token: 0x04012E2F RID: 77359
		Local,
		// Token: 0x04012E30 RID: 77360
		Custom,
		// Token: 0x04012E31 RID: 77361
		DISPLAY_ONLY_StaticSwitch,
		// Token: 0x04012E32 RID: 77362
		Output,
		// Token: 0x04012E33 RID: 77363
		None,
		// Token: 0x04012E34 RID: 77364
		Num,
		// Token: 0x04012E35 RID: 77365
		ENiagaraParameterScope_MAX
	}
}
