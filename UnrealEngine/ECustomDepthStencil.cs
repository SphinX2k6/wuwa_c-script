using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A39 RID: 2617
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECustomDepthStencil")]
	public enum ECustomDepthStencil
	{
		// Token: 0x04004605 RID: 17925
		Disabled,
		// Token: 0x04004606 RID: 17926
		Enabled,
		// Token: 0x04004607 RID: 17927
		EnabledOnDemand,
		// Token: 0x04004608 RID: 17928
		EnabledWithStencil,
		// Token: 0x04004609 RID: 17929
		ECustomDepthStencil_MAX
	}
}
