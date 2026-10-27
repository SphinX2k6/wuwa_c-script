using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA0 RID: 2976
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETranslucencyType")]
	public enum ETranslucencyType : byte
	{
		// Token: 0x040051F2 RID: 20978
		Raster,
		// Token: 0x040051F3 RID: 20979
		RayTracing,
		// Token: 0x040051F4 RID: 20980
		ETranslucencyType_MAX
	}
}
