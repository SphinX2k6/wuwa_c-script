using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B26 RID: 2854
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorBlendFactor")]
	public enum EPSOGeneratorBlendFactor
	{
		// Token: 0x04004E16 RID: 19990
		PSO_BF_Zero,
		// Token: 0x04004E17 RID: 19991
		PSO_BF_One,
		// Token: 0x04004E18 RID: 19992
		PSO_BF_SourceColor,
		// Token: 0x04004E19 RID: 19993
		PSO_BF_InverseSourceColor,
		// Token: 0x04004E1A RID: 19994
		PSO_BF_SourceAlpha,
		// Token: 0x04004E1B RID: 19995
		PSO_BF_InverseSourceAlpha,
		// Token: 0x04004E1C RID: 19996
		PSO_BF_DestAlpha,
		// Token: 0x04004E1D RID: 19997
		PSO_BF_InverseDestAlpha,
		// Token: 0x04004E1E RID: 19998
		PSO_BF_DestColor,
		// Token: 0x04004E1F RID: 19999
		PSO_BF_InverseDestColor,
		// Token: 0x04004E20 RID: 20000
		PSO_BF_ConstantBlendFactor,
		// Token: 0x04004E21 RID: 20001
		PSO_BF_InverseConstantBlendFactor,
		// Token: 0x04004E22 RID: 20002
		PSO_BF_Source1Color,
		// Token: 0x04004E23 RID: 20003
		PSO_BF_InverseSource1Color,
		// Token: 0x04004E24 RID: 20004
		PSO_BF_Source1Alpha,
		// Token: 0x04004E25 RID: 20005
		PSO_BF_InverseSource1Alpha,
		// Token: 0x04004E26 RID: 20006
		PSO_BF_MAX
	}
}
