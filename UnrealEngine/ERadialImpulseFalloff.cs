using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002643 RID: 9795
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PhysicsCore.ERadialImpulseFalloff")]
	public enum ERadialImpulseFalloff
	{
		// Token: 0x040138D6 RID: 80086
		RIF_Constant,
		// Token: 0x040138D7 RID: 80087
		RIF_Linear,
		// Token: 0x040138D8 RID: 80088
		RIF_MAX
	}
}
