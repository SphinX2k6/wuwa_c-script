using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B28 RID: 2856
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorColorWriteMask")]
	public enum EPSOGeneratorColorWriteMask
	{
		// Token: 0x04004E2F RID: 20015
		PSO_CW_RED = 1,
		// Token: 0x04004E30 RID: 20016
		PSO_CW_GREEN,
		// Token: 0x04004E31 RID: 20017
		PSO_CW_BLUE = 4,
		// Token: 0x04004E32 RID: 20018
		PSO_CW_ALPHA = 8,
		// Token: 0x04004E33 RID: 20019
		PSO_CW_NONE = 0,
		// Token: 0x04004E34 RID: 20020
		PSO_CW_RGB = 7,
		// Token: 0x04004E35 RID: 20021
		PSO_CW_RGBA = 15,
		// Token: 0x04004E36 RID: 20022
		PSO_CW_RG = 3,
		// Token: 0x04004E37 RID: 20023
		PSO_CW_BA = 12,
		// Token: 0x04004E38 RID: 20024
		PSO_CW_GBA = 14,
		// Token: 0x04004E39 RID: 20025
		PSO_CW_MAX = 16
	}
}
