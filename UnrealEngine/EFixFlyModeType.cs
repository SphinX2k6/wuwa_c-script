using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F20 RID: 7968
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EFixFlyModeType")]
	public enum EFixFlyModeType : byte
	{
		// Token: 0x040104FD RID: 66813
		FixHook,
		// Token: 0x040104FE RID: 66814
		Catapult,
		// Token: 0x040104FF RID: 66815
		EFixFlyModeType_MAX
	}
}
