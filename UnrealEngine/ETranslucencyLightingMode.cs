using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B9F RID: 2975
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETranslucencyLightingMode")]
	public enum ETranslucencyLightingMode
	{
		// Token: 0x040051EA RID: 20970
		TLM_VolumetricNonDirectional,
		// Token: 0x040051EB RID: 20971
		TLM_VolumetricDirectional,
		// Token: 0x040051EC RID: 20972
		TLM_VolumetricPerVertexNonDirectional,
		// Token: 0x040051ED RID: 20973
		TLM_VolumetricPerVertexDirectional,
		// Token: 0x040051EE RID: 20974
		TLM_Surface,
		// Token: 0x040051EF RID: 20975
		TLM_SurfacePerPixelLighting,
		// Token: 0x040051F0 RID: 20976
		TLM_MAX
	}
}
