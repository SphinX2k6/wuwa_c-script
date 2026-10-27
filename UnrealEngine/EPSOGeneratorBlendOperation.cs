using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B27 RID: 2855
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorBlendOperation")]
	public enum EPSOGeneratorBlendOperation
	{
		// Token: 0x04004E28 RID: 20008
		PSO_BO_Add,
		// Token: 0x04004E29 RID: 20009
		PSO_BO_Subtract,
		// Token: 0x04004E2A RID: 20010
		PSO_BO_Min,
		// Token: 0x04004E2B RID: 20011
		PSO_BO_Max,
		// Token: 0x04004E2C RID: 20012
		PSO_BO_ReverseSubtract,
		// Token: 0x04004E2D RID: 20013
		PSO_BO_MAX
	}
}
