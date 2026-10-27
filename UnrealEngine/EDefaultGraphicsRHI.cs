using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A6B RID: 10859
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WindowsTargetPlatform.EDefaultGraphicsRHI")]
	public enum EDefaultGraphicsRHI : byte
	{
		// Token: 0x04015FBB RID: 90043
		DefaultGraphicsRHI_Default,
		// Token: 0x04015FBC RID: 90044
		DefaultGraphicsRHI_DX11,
		// Token: 0x04015FBD RID: 90045
		DefaultGraphicsRHI_DX12,
		// Token: 0x04015FBE RID: 90046
		DefaultGraphicsRHI_Vulkan,
		// Token: 0x04015FBF RID: 90047
		DefaultGraphicsRHI_MAX
	}
}
