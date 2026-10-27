using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200250D RID: 9485
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraVariantMode")]
	public enum ENiagaraVariantMode
	{
		// Token: 0x04012EB2 RID: 77490
		None,
		// Token: 0x04012EB3 RID: 77491
		Object,
		// Token: 0x04012EB4 RID: 77492
		DataInterface,
		// Token: 0x04012EB5 RID: 77493
		Bytes,
		// Token: 0x04012EB6 RID: 77494
		ENiagaraVariantMode_MAX
	}
}
