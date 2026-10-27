using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B29 RID: 2857
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorCompareFunction")]
	public enum EPSOGeneratorCompareFunction
	{
		// Token: 0x04004E3B RID: 20027
		PSO_CF_Less,
		// Token: 0x04004E3C RID: 20028
		PSO_CF_LessEqual,
		// Token: 0x04004E3D RID: 20029
		PSO_CF_Greater,
		// Token: 0x04004E3E RID: 20030
		PSO_CF_GreaterEqual,
		// Token: 0x04004E3F RID: 20031
		PSO_CF_Equal,
		// Token: 0x04004E40 RID: 20032
		PSO_CF_NotEqual,
		// Token: 0x04004E41 RID: 20033
		PSO_CF_Never,
		// Token: 0x04004E42 RID: 20034
		PSO_CF_Always,
		// Token: 0x04004E43 RID: 20035
		PSO_CF_MAX
	}
}
