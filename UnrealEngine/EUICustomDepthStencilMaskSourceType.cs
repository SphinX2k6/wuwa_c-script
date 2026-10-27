using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002000 RID: 8192
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUICustomDepthStencilMaskSourceType")]
	public enum EUICustomDepthStencilMaskSourceType : byte
	{
		// Token: 0x04010C5C RID: 68700
		CustomDepth,
		// Token: 0x04010C5D RID: 68701
		CustomStencil,
		// Token: 0x04010C5E RID: 68702
		EUICustomDepthStencilMaskSourceType_MAX
	}
}
