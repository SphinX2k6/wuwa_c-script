using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A42 RID: 2626
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDefaultBackBufferPixelFormat")]
	public enum EDefaultBackBufferPixelFormat
	{
		// Token: 0x04004650 RID: 18000
		DBBPF_B8G8R8A8,
		// Token: 0x04004651 RID: 18001
		DBBPF_A16B16G16R16_DEPRECATED,
		// Token: 0x04004652 RID: 18002
		DBBPF_FloatRGB_DEPRECATED,
		// Token: 0x04004653 RID: 18003
		DBBPF_FloatRGBA,
		// Token: 0x04004654 RID: 18004
		DBBPF_A2B10G10R10,
		// Token: 0x04004655 RID: 18005
		DBBPF_MAX
	}
}
