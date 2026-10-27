using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B66 RID: 2918
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESkyAtmosphereTransformMode")]
	public enum ESkyAtmosphereTransformMode : byte
	{
		// Token: 0x04005062 RID: 20578
		PlanetTopAtAbsoluteWorldOrigin,
		// Token: 0x04005063 RID: 20579
		PlanetTopAtComponentTransform,
		// Token: 0x04005064 RID: 20580
		PlanetCenterAtComponentTransform,
		// Token: 0x04005065 RID: 20581
		ESkyAtmosphereTransformMode_MAX
	}
}
