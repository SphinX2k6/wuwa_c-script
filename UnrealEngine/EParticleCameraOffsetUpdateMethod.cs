using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B09 RID: 2825
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleCameraOffsetUpdateMethod")]
	public enum EParticleCameraOffsetUpdateMethod
	{
		// Token: 0x04004D65 RID: 19813
		EPCOUM_DirectSet,
		// Token: 0x04004D66 RID: 19814
		EPCOUM_Additive,
		// Token: 0x04004D67 RID: 19815
		EPCOUM_Scalar,
		// Token: 0x04004D68 RID: 19816
		EPCOUM_MAX
	}
}
