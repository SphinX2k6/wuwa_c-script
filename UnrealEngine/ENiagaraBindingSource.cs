using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024E2 RID: 9442
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraBindingSource")]
	public enum ENiagaraBindingSource
	{
		// Token: 0x04012DB9 RID: 77241
		ImplicitFromSource,
		// Token: 0x04012DBA RID: 77242
		ExplicitParticles,
		// Token: 0x04012DBB RID: 77243
		ExplicitEmitter,
		// Token: 0x04012DBC RID: 77244
		ExplicitSystem,
		// Token: 0x04012DBD RID: 77245
		ExplicitUser,
		// Token: 0x04012DBE RID: 77246
		MaxBindingSource,
		// Token: 0x04012DBF RID: 77247
		ENiagaraBindingSource_MAX
	}
}
