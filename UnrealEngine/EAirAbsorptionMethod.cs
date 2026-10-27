using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E5 RID: 2533
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAirAbsorptionMethod")]
	public enum EAirAbsorptionMethod : byte
	{
		// Token: 0x040043FD RID: 17405
		Linear,
		// Token: 0x040043FE RID: 17406
		CustomCurve,
		// Token: 0x040043FF RID: 17407
		EAirAbsorptionMethod_MAX
	}
}
