using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AB9 RID: 2745
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialParameterAssociation")]
	public enum EMaterialParameterAssociation
	{
		// Token: 0x040049B2 RID: 18866
		LayerParameter,
		// Token: 0x040049B3 RID: 18867
		BlendParameter,
		// Token: 0x040049B4 RID: 18868
		GlobalParameter,
		// Token: 0x040049B5 RID: 18869
		EMaterialParameterAssociation_MAX
	}
}
