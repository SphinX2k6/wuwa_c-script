using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A70 RID: 2672
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFlowMapSVTRuntimePixelFormat")]
	public enum EFlowMapSVTRuntimePixelFormat : byte
	{
		// Token: 0x040047AF RID: 18351
		RG16F,
		// Token: 0x040047B0 RID: 18352
		RGBA8,
		// Token: 0x040047B1 RID: 18353
		RGBA16F,
		// Token: 0x040047B2 RID: 18354
		RG8,
		// Token: 0x040047B3 RID: 18355
		R32F,
		// Token: 0x040047B4 RID: 18356
		EFlowMapSVTRuntimePixelFormat_MAX
	}
}
