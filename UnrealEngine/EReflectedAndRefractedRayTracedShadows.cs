using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B3F RID: 2879
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EReflectedAndRefractedRayTracedShadows")]
	public enum EReflectedAndRefractedRayTracedShadows : byte
	{
		// Token: 0x04004F56 RID: 20310
		Disabled,
		// Token: 0x04004F57 RID: 20311
		Hard_shadows,
		// Token: 0x04004F58 RID: 20312
		Area_shadows,
		// Token: 0x04004F59 RID: 20313
		EReflectedAndRefractedRayTracedShadows_MAX
	}
}
