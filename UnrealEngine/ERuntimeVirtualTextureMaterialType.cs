using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B54 RID: 2900
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERuntimeVirtualTextureMaterialType")]
	public enum ERuntimeVirtualTextureMaterialType : byte
	{
		// Token: 0x04004FCF RID: 20431
		BaseColor,
		// Token: 0x04004FD0 RID: 20432
		BaseColor_Normal_DEPRECATED,
		// Token: 0x04004FD1 RID: 20433
		BaseColor_Normal_Specular,
		// Token: 0x04004FD2 RID: 20434
		BaseColor_Normal_Specular_YCoCg,
		// Token: 0x04004FD3 RID: 20435
		BaseColor_Normal_Specular_Mask_YCoCg,
		// Token: 0x04004FD4 RID: 20436
		WorldHeight,
		// Token: 0x04004FD5 RID: 20437
		Count,
		// Token: 0x04004FD6 RID: 20438
		ERuntimeVirtualTextureMaterialType_MAX
	}
}
