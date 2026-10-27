using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020011DB RID: 4571
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.TextureMipGenSettings")]
	public enum TextureMipGenSettings
	{
		// Token: 0x04009048 RID: 36936
		TMGS_FromTextureGroup,
		// Token: 0x04009049 RID: 36937
		TMGS_SimpleAverage,
		// Token: 0x0400904A RID: 36938
		TMGS_Sharpen0,
		// Token: 0x0400904B RID: 36939
		TMGS_Sharpen1,
		// Token: 0x0400904C RID: 36940
		TMGS_Sharpen2,
		// Token: 0x0400904D RID: 36941
		TMGS_Sharpen3,
		// Token: 0x0400904E RID: 36942
		TMGS_Sharpen4,
		// Token: 0x0400904F RID: 36943
		TMGS_Sharpen5,
		// Token: 0x04009050 RID: 36944
		TMGS_Sharpen6,
		// Token: 0x04009051 RID: 36945
		TMGS_Sharpen7,
		// Token: 0x04009052 RID: 36946
		TMGS_Sharpen8,
		// Token: 0x04009053 RID: 36947
		TMGS_Sharpen9,
		// Token: 0x04009054 RID: 36948
		TMGS_Sharpen10,
		// Token: 0x04009055 RID: 36949
		TMGS_NoMipmaps,
		// Token: 0x04009056 RID: 36950
		TMGS_LeaveExistingMips,
		// Token: 0x04009057 RID: 36951
		TMGS_Blur1,
		// Token: 0x04009058 RID: 36952
		TMGS_Blur2,
		// Token: 0x04009059 RID: 36953
		TMGS_Blur3,
		// Token: 0x0400905A RID: 36954
		TMGS_Blur4,
		// Token: 0x0400905B RID: 36955
		TMGS_Blur5,
		// Token: 0x0400905C RID: 36956
		TMGS_Unfiltered,
		// Token: 0x0400905D RID: 36957
		TMGS_BuildFromSourceImage,
		// Token: 0x0400905E RID: 36958
		TMGS_MAX
	}
}
