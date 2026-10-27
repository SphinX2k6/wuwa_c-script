using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B53 RID: 2899
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERuntimeVirtualTextureMainPassType")]
	public enum ERuntimeVirtualTextureMainPassType : byte
	{
		// Token: 0x04004FCA RID: 20426
		Never,
		// Token: 0x04004FCB RID: 20427
		Exclusive,
		// Token: 0x04004FCC RID: 20428
		Always,
		// Token: 0x04004FCD RID: 20429
		ERuntimeVirtualTextureMainPassType_MAX
	}
}
