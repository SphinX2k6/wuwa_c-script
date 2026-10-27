using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B57 RID: 2903
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESamplerSourceMode")]
	public enum ESamplerSourceMode
	{
		// Token: 0x04004FE1 RID: 20449
		SSM_FromTextureAsset,
		// Token: 0x04004FE2 RID: 20450
		SSM_Wrap_WorldGroupSettings,
		// Token: 0x04004FE3 RID: 20451
		SSM_Clamp_WorldGroupSettings,
		// Token: 0x04004FE4 RID: 20452
		SSM_MAX
	}
}
