using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024ED RID: 9453
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraInputNodeUsage")]
	public enum ENiagaraInputNodeUsage : byte
	{
		// Token: 0x04012DF2 RID: 77298
		Undefined,
		// Token: 0x04012DF3 RID: 77299
		Parameter,
		// Token: 0x04012DF4 RID: 77300
		Attribute,
		// Token: 0x04012DF5 RID: 77301
		SystemConstant,
		// Token: 0x04012DF6 RID: 77302
		TranslatorConstant,
		// Token: 0x04012DF7 RID: 77303
		RapidIterationParameter,
		// Token: 0x04012DF8 RID: 77304
		ENiagaraInputNodeUsage_MAX
	}
}
